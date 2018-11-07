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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestCasePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TestCasePath;
        private System.Windows.Forms.Label label1;
    }
}