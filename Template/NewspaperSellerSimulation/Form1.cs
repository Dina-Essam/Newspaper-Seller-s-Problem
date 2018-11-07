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
        SimulationSystem SS = new SimulationSystem();
        public Form1()
        {
            InitializeComponent();            
        }

        private void TestCasePath_SelectedIndexChanged(object sender, EventArgs e)
        {
            SS.ReadINPUT(TestCasePath.SelectedItem.ToString());
            SS.fillTable();
            SS.FillPerformanceMeasures();
            String TestingResult = TestingManager.Test(SS,Constants.FileNames.TestCase1);
           // MessageBox.Show(TestingResult);

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
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
