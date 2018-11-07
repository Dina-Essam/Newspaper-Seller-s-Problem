namespace NewspaperSellerSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestCasePath = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DaysDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TypeofNewdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitAssignment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomfortypeofNewsday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomforDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenuefromsales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostprofit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyprofit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalSalesRevenue = new System.Windows.Forms.TextBox();
            this.TotalCostofNewspapers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalLostProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalSalvage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NetProfit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // TestCasePath
            // 
            this.TestCasePath.FormattingEnabled = true;
            this.TestCasePath.Items.AddRange(new object[] {
            "TestCase1",
            "TestCase2",
            "TestCase3"});
            this.TestCasePath.Location = new System.Drawing.Point(89, 24);
            this.TestCasePath.Name = "TestCasePath";
            this.TestCasePath.Size = new System.Drawing.Size(121, 21);
            this.TestCasePath.TabIndex = 0;
            this.TestCasePath.SelectedIndexChanged += new System.EventHandler(this.TestCasePath_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TestCases";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DaysDemand,
            this.Good1,
            this.Fair1,
            this.Poor1,
            this.Good2,
            this.Fair2,
            this.Poor2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 108);
            this.dataGridView1.TabIndex = 2;
            // 
            // DaysDemand
            // 
            this.DaysDemand.HeaderText = "Demand";
            this.DaysDemand.Name = "DaysDemand";
            // 
            // Good1
            // 
            this.Good1.HeaderText = "Good";
            this.Good1.Name = "Good1";
            // 
            // Fair1
            // 
            this.Fair1.HeaderText = "Fair";
            this.Fair1.Name = "Fair1";
            // 
            // Poor1
            // 
            this.Poor1.HeaderText = "Poor";
            this.Poor1.Name = "Poor1";
            // 
            // Good2
            // 
            this.Good2.HeaderText = "Good";
            this.Good2.Name = "Good2";
            // 
            // Fair2
            // 
            this.Fair2.HeaderText = "Fair";
            this.Fair2.Name = "Fair2";
            // 
            // Poor2
            // 
            this.Poor2.HeaderText = "Poor";
            this.Poor2.Name = "Poor2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeofNewdays,
            this.Probability,
            this.CumulativeProbability,
            this.RandomDigitAssignment});
            this.dataGridView2.Location = new System.Drawing.Point(12, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(312, 98);
            this.dataGridView2.TabIndex = 3;
            // 
            // TypeofNewdays
            // 
            this.TypeofNewdays.HeaderText = "Type of Newdays";
            this.TypeofNewdays.Name = "TypeofNewdays";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // CumulativeProbability
            // 
            this.CumulativeProbability.HeaderText = "Cumulative Probability";
            this.CumulativeProbability.Name = "CumulativeProbability";
            // 
            // RandomDigitAssignment
            // 
            this.RandomDigitAssignment.HeaderText = "Random Digit Assignment";
            this.RandomDigitAssignment.Name = "RandomDigitAssignment";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.RandomfortypeofNewsday,
            this.NewsDayType,
            this.RandomforDemand,
            this.Demand,
            this.revenuefromsales,
            this.lostprofit,
            this.salvage,
            this.dailyprofit});
            this.dataGridView3.Location = new System.Drawing.Point(333, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(938, 518);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // RandomfortypeofNewsday
            // 
            this.RandomfortypeofNewsday.HeaderText = "Random for type of Newsday";
            this.RandomfortypeofNewsday.Name = "RandomfortypeofNewsday";
            // 
            // NewsDayType
            // 
            this.NewsDayType.HeaderText = "NewsDay Type";
            this.NewsDayType.Name = "NewsDayType";
            // 
            // RandomforDemand
            // 
            this.RandomforDemand.HeaderText = "Random for Demand";
            this.RandomforDemand.Name = "RandomforDemand";
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // revenuefromsales
            // 
            this.revenuefromsales.HeaderText = "Revenue from Sales";
            this.revenuefromsales.Name = "revenuefromsales";
            // 
            // lostprofit
            // 
            this.lostprofit.HeaderText = "lost profit";
            this.lostprofit.Name = "lostprofit";
            // 
            // salvage
            // 
            this.salvage.HeaderText = "salvage";
            this.salvage.Name = "salvage";
            // 
            // dailyprofit
            // 
            this.dailyprofit.HeaderText = "Daily Profit";
            this.dailyprofit.Name = "dailyprofit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Sales Revenue";
            // 
            // TotalSalesRevenue
            // 
            this.TotalSalesRevenue.Location = new System.Drawing.Point(208, 299);
            this.TotalSalesRevenue.Name = "TotalSalesRevenue";
            this.TotalSalesRevenue.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesRevenue.TabIndex = 6;
            // 
            // TotalCostofNewspapers
            // 
            this.TotalCostofNewspapers.Location = new System.Drawing.Point(208, 322);
            this.TotalCostofNewspapers.Name = "TotalCostofNewspapers";
            this.TotalCostofNewspapers.Size = new System.Drawing.Size(100, 20);
            this.TotalCostofNewspapers.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Cost of Newspapers";
            // 
            // TotalLostProfit
            // 
            this.TotalLostProfit.Location = new System.Drawing.Point(208, 346);
            this.TotalLostProfit.Name = "TotalLostProfit";
            this.TotalLostProfit.Size = new System.Drawing.Size(100, 20);
            this.TotalLostProfit.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Lost Profit ";
            // 
            // TotalSalvage
            // 
            this.TotalSalvage.Location = new System.Drawing.Point(208, 368);
            this.TotalSalvage.Name = "TotalSalvage";
            this.TotalSalvage.Size = new System.Drawing.Size(100, 20);
            this.TotalSalvage.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Salvage";
            // 
            // NetProfit
            // 
            this.NetProfit.Location = new System.Drawing.Point(208, 390);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(100, 20);
            this.NetProfit.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Net Profit";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(208, 414);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Number of days having excess demand";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(208, 439);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Number of days having unsold papers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 542);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NetProfit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalSalvage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalLostProfit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TotalCostofNewspapers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalSalesRevenue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestCasePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TestCasePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomfortypeofNewsday;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomforDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenuefromsales;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostprofit;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyprofit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeofNewdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitAssignment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TotalSalesRevenue;
        private System.Windows.Forms.TextBox TotalCostofNewspapers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalLostProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalSalvage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NetProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
    }
}