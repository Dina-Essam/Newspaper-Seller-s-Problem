using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        ////////////// FillInput /////////////
        private void DistributionsOfNewsDays()
        {

            DayTypeDistributions.ElementAt(0).CummProbability = DayTypeDistributions.ElementAt(0).Probability;
            DayTypeDistributions.ElementAt(0).MinRange = 1;
            DayTypeDistributions.ElementAt(0).MaxRange = Convert.ToInt32(DayTypeDistributions.ElementAt(0).CummProbability * 100);

            DayTypeDistributions.ElementAt(1).CummProbability = DayTypeDistributions.ElementAt(1).Probability + DayTypeDistributions.ElementAt(0).CummProbability;
            if (DayTypeDistributions.ElementAt(1).Probability == 0)
            {
                DayTypeDistributions.ElementAt(1).MinRange = DayTypeDistributions.ElementAt(0).MaxRange;
                DayTypeDistributions.ElementAt(1).MaxRange = Convert.ToInt32(DayTypeDistributions.ElementAt(1).CummProbability * 100);
            }
            else
            {
                DayTypeDistributions.ElementAt(1).MinRange = DayTypeDistributions.ElementAt(0).MaxRange + 1;
                DayTypeDistributions.ElementAt(1).MaxRange = Convert.ToInt32(DayTypeDistributions.ElementAt(1).CummProbability * 100);
            }


            DayTypeDistributions.ElementAt(2).CummProbability = DayTypeDistributions.ElementAt(2).Probability + DayTypeDistributions.ElementAt(1).CummProbability;
            if (DayTypeDistributions.ElementAt(2).Probability == 0)
            {
                DayTypeDistributions.ElementAt(2).MinRange = DayTypeDistributions.ElementAt(1).MaxRange;
                DayTypeDistributions.ElementAt(2).MaxRange = Convert.ToInt32(DayTypeDistributions.ElementAt(2).CummProbability * 100);
            }
            else
            {
                DayTypeDistributions.ElementAt(2).MinRange = DayTypeDistributions.ElementAt(1).MaxRange + 1;
                DayTypeDistributions.ElementAt(2).MaxRange = Convert.ToInt32(DayTypeDistributions.ElementAt(2).CummProbability * 100);
            }

        }
        private void DistributionsOfDemand()
        {
            for (int i = 0; i < 3; i++)
            {
                DemandDistributions.ElementAt(0).DayTypeDistributions.ElementAt(i).CummProbability = DemandDistributions.ElementAt(0).DayTypeDistributions.ElementAt(i).Probability;
                DemandDistributions.ElementAt(0).DayTypeDistributions.ElementAt(i).MinRange = 1;
                DemandDistributions.ElementAt(0).DayTypeDistributions.ElementAt(i).MaxRange = Convert.ToInt32(DemandDistributions.ElementAt(0).DayTypeDistributions.ElementAt(i).CummProbability * 100);

                for (int j = 1; j < DemandDistributions.Count; j++)
                {
                    if (DemandDistributions.ElementAt(j - 1).DayTypeDistributions.ElementAt(i).CummProbability == 1)
                        DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).CummProbability = 1;
                    else
                        DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).CummProbability = DemandDistributions.ElementAt(j - 1).DayTypeDistributions.ElementAt(i).CummProbability + DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).Probability;

                    if (DemandDistributions.ElementAt(j - 1).DayTypeDistributions.ElementAt(i).MaxRange == 100 || DemandDistributions.ElementAt(j - 1).DayTypeDistributions.ElementAt(i).MaxRange == 0)
                    {
                        DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).MaxRange = 0;
                        DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).MinRange = 0;
                    }
                    else
                    {
                        DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).MinRange = DemandDistributions.ElementAt(j - 1).DayTypeDistributions.ElementAt(i).MaxRange + 1;
                        DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).MaxRange = Convert.ToInt32(DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(i).CummProbability * 100);
                    }

                }

            }
        }
        public void ReadINPUT(string textfilename)
        {
            string[] Separator = new string[1] { "," + " " };
            string[] lines = System.IO.File.ReadAllLines("../../TestCases/" + textfilename + ".txt");
            NumOfNewspapers = Convert.ToInt32(lines.ElementAt(1));
            NumOfRecords = Convert.ToInt32(lines.ElementAt(4));
            PurchasePrice = Convert.ToDecimal(lines.ElementAt(7));
            SellingPrice = Convert.ToDecimal(lines.ElementAt(13));
            ScrapPrice = Convert.ToDecimal(lines.ElementAt(10));
            UnitProfit = SellingPrice - PurchasePrice;
            string[] DayTypes = lines.ElementAt(16).Split(Separator, StringSplitOptions.None);
            for (int i = 0; i < 3; i++)
            {
                DayTypeDistribution DTD = new DayTypeDistribution((Enums.DayType)(i), Convert.ToDecimal(DayTypes[i]));
                DayTypeDistributions.Add(DTD);
            }
            for (int i = 19; i < lines.Count(); i++)
            {
                DayTypes = lines.ElementAt(i).Split(Separator, StringSplitOptions.None);
                DemandDistribution DD = new DemandDistribution();
                DD.Demand = Convert.ToInt32(DayTypes[0]);
                for (int j = 1; j <= 3; j++)
                {
                    DayTypeDistribution DTD = new DayTypeDistribution((Enums.DayType)(j - 1), Convert.ToDecimal(DayTypes[j]));
                    DD.DayTypeDistributions.Add(DTD);
                }
                DemandDistributions.Add(DD);
            }
            DistributionsOfNewsDays();
            DistributionsOfDemand();
        }
        ////////////// PerformanceMeasures //////////////
        private void TotalSalesRevenue()
        {
            PerformanceMeasures.TotalSalesProfit = 0;
            foreach (SimulationCase Day in SimulationTable)
            {
                PerformanceMeasures.TotalSalesProfit += Day.SalesProfit;
            }
        }
        private void TotalCost()
        {
            PerformanceMeasures.TotalCost = (NumOfNewspapers * PurchasePrice) * NumOfRecords;
        }
        private void TotalLostProfit()
        {
            PerformanceMeasures.TotalLostProfit = 0;
            foreach (SimulationCase Day in SimulationTable)
            {
                PerformanceMeasures.TotalLostProfit += Day.LostProfit;
            }
        }
        private void TotalScrapProfit()
        {
            PerformanceMeasures.TotalScrapProfit = 0;
            foreach (SimulationCase Day in SimulationTable)
            {
                PerformanceMeasures.TotalScrapProfit += Day.ScrapProfit;
            }
        }
        private void TotalNetProfit()
        {
            PerformanceMeasures.TotalNetProfit = 0;
            foreach (SimulationCase Day in SimulationTable)
            {
                PerformanceMeasures.TotalNetProfit += Day.DailyNetProfit;
            }
        }
        private void DaysWithMoreDemand()
        {
            PerformanceMeasures.DaysWithMoreDemand = 0;
            foreach (SimulationCase Day in SimulationTable)
            {
                if (Day.LostProfit != 0)
                    PerformanceMeasures.DaysWithMoreDemand++;
            }
        }
        private void DaysWithUnsoldPapers()
        {
            PerformanceMeasures.DaysWithUnsoldPapers = 0;
            foreach (SimulationCase Day in SimulationTable)
            {
                if (Day.ScrapProfit != 0)
                    PerformanceMeasures.DaysWithUnsoldPapers++;
            }
        }
        public void FillPerformanceMeasures()
        {
            TotalSalesRevenue();
            TotalCost();
            TotalLostProfit();
            TotalScrapProfit();
            TotalNetProfit();
            DaysWithMoreDemand();
            DaysWithUnsoldPapers();
        }
        ///////////// SimulationTable ////////////////
        public void fillTable()
        {
            Random rand = new Random();
            for (int i = 1; i <= NumOfRecords; i++)
            {

                SimulationCase sc = new SimulationCase();
                sc.DayNo = i;

                sc.RandomNewsDayType = rand.Next(1, 101);
                sc.RandomDemand = rand.Next(1, 101);

                if (sc.RandomNewsDayType >= DayTypeDistributions.ElementAt(0).MinRange && sc.RandomNewsDayType <= DayTypeDistributions.ElementAt(0).MaxRange)
                {
                    sc.NewsDayType = Enums.DayType.Good;
                }
                else if (sc.RandomNewsDayType >= DayTypeDistributions.ElementAt(1).MinRange && sc.RandomNewsDayType <= DayTypeDistributions.ElementAt(1).MaxRange)
                {
                    sc.NewsDayType = Enums.DayType.Fair;
                }
                else
                {
                    sc.NewsDayType = Enums.DayType.Poor;

                }


                if (sc.NewsDayType == Enums.DayType.Good)
                {
                    for (int j = 0; j < DemandDistributions.Count; j++)
                    {
                        if (sc.RandomDemand >= DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(0).MinRange && sc.RandomDemand <= DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(0).MaxRange)
                        {
                            sc.Demand = DemandDistributions.ElementAt(j).Demand;
                        }
                    }

                }



                else if (sc.NewsDayType == Enums.DayType.Fair)
                {
                    for (int j = 0; j < DemandDistributions.Count; j++)
                    {
                        if (sc.RandomDemand >= DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(1).MinRange && sc.RandomDemand <= DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(1).MaxRange)
                        {
                            sc.Demand = DemandDistributions.ElementAt(j).Demand;
                        }
                    }

                }
                else
                {
                    for (int j = 0; j < DemandDistributions.Count; j++)
                    {
                        if (sc.RandomDemand >= DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(2).MinRange && sc.RandomDemand <= DemandDistributions.ElementAt(j).DayTypeDistributions.ElementAt(2).MaxRange)
                        {
                            sc.Demand = DemandDistributions.ElementAt(j).Demand;
                        }
                    }
                }




                sc.DailyCost = NumOfNewspapers * PurchasePrice;
                if (sc.Demand >= NumOfNewspapers)
                {
                    sc.SalesProfit = NumOfNewspapers * SellingPrice;
                    sc.LostProfit = (sc.Demand - NumOfNewspapers) * (SellingPrice - PurchasePrice);
                    sc.ScrapProfit = 0;
                }

                else if (NumOfNewspapers > sc.Demand)
                {
                    sc.SalesProfit = sc.Demand * SellingPrice;
                    sc.ScrapProfit = (NumOfNewspapers - sc.Demand) * ScrapPrice;
                    sc.LostProfit = 0;
                }
                sc.DailyNetProfit = sc.SalesProfit - sc.DailyCost - sc.LostProfit + sc.ScrapProfit;
                SimulationTable.Add(sc);
            }

        }
    }
}
