using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem SS;
        public Form1()
        {
            InitializeComponent();
        }

        private void TestCasePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            SS = new SimulationSystem();
            SS.ReadINPUT(TestCasePath.SelectedItem.ToString());
            SS.fillTable();
            SS.FillPerformanceMeasures();
            String TestingResult = TestingManager.Test(SS, Constants.FileNames.TestCase1);
            MessageBox.Show(TestingResult);
            /////////////Clear data/////////////
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            // dataGridView3.Rows.Add(SS.NumOfRecords);
            for (int i = 0; i < SS.NumOfRecords; i++)
            {
                dataGridView3.Rows.Add(1);
                dataGridView3.Rows[i].Cells[0].Value = SS.SimulationTable.ElementAt(i).DayNo;
                dataGridView3.Rows[i].Cells[1].Value = SS.SimulationTable.ElementAt(i).RandomNewsDayType;
                dataGridView3.Rows[i].Cells[2].Value = SS.SimulationTable.ElementAt(i).NewsDayType;
                dataGridView3.Rows[i].Cells[3].Value = SS.SimulationTable.ElementAt(i).RandomDemand;
                dataGridView3.Rows[i].Cells[4].Value = SS.SimulationTable.ElementAt(i).Demand;
                dataGridView3.Rows[i].Cells[5].Value = SS.SimulationTable.ElementAt(i).SalesProfit;
                dataGridView3.Rows[i].Cells[6].Value = SS.SimulationTable.ElementAt(i).LostProfit;
                dataGridView3.Rows[i].Cells[7].Value = SS.SimulationTable.ElementAt(i).ScrapProfit;
                dataGridView3.Rows[i].Cells[8].Value = SS.SimulationTable.ElementAt(i).DailyNetProfit;

            }

            for (int i = 0; i < 3; i++)
            {
                dataGridView2.Rows.Add(1);
                dataGridView2.Rows[i].Cells[0].Value = SS.DayTypeDistributions.ElementAt(i).DayType;
                dataGridView2.Rows[i].Cells[1].Value = SS.DayTypeDistributions.ElementAt(i).Probability;
                dataGridView2.Rows[i].Cells[2].Value = SS.DayTypeDistributions.ElementAt(i).CummProbability;
                dataGridView2.Rows[i].Cells[3].Value = SS.DayTypeDistributions.ElementAt(i).MinRange + " - " + SS.DayTypeDistributions.ElementAt(i).MaxRange;
            }

            for (int i = 0; i < SS.DemandDistributions.Count; i++)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i].Cells[0].Value = SS.DemandDistributions.ElementAt(i).Demand;
                dataGridView1.Rows[i].Cells[1].Value = SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(0).Probability;
                dataGridView1.Rows[i].Cells[2].Value = SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(1).Probability;
                dataGridView1.Rows[i].Cells[3].Value = SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(2).Probability;
                dataGridView1.Rows[i].Cells[4].Value = SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(0).MinRange + " - " + SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(0).MaxRange;
                dataGridView1.Rows[i].Cells[5].Value = SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(1).MinRange + " - " + SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(1).MaxRange;
                dataGridView1.Rows[i].Cells[6].Value = SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(2).MinRange + " - " + SS.DemandDistributions.ElementAt(i).DayTypeDistributions.ElementAt(2).MaxRange;
            }

            ///////////performance////////////////////
            TotalSalesRevenue.Text = SS.PerformanceMeasures.TotalSalesProfit.ToString();
            TotalCostofNewspapers.Text = SS.PerformanceMeasures.TotalCost.ToString();
            TotalLostProfit.Text = SS.PerformanceMeasures.TotalLostProfit.ToString();
            TotalSalvage.Text = SS.PerformanceMeasures.TotalScrapProfit.ToString();
            NetProfit.Text = SS.PerformanceMeasures.TotalNetProfit.ToString();
            textBox6.Text = SS.PerformanceMeasures.DaysWithMoreDemand.ToString();
            textBox7.Text = SS.PerformanceMeasures.DaysWithUnsoldPapers.ToString();

        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
