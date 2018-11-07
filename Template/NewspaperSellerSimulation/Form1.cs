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
            //SS.FillPerformanceMeasures();
            String TestingResult = TestingManager.Test(SS,Constants.FileNames.TestCase1);
            MessageBox.Show(TestingResult);
        }

        
    }
}
