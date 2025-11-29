namespace Lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer
        private void InitializeComponent()
        {
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.radOneRoll = new System.Windows.Forms.RadioButton();
            this.radStats = new System.Windows.Forms.RadioButton();
            this.grpOneRoll = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSwapNumbers = new System.Windows.Forms.Button();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblRollNameValue = new System.Windows.Forms.Label();
            this.lblDice2Value = new System.Windows.Forms.Label();
            this.lblDice1Value = new System.Windows.Forms.Label();
            this.lblRollName = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblOneRollText = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblFailValue = new System.Windows.Forms.Label();
            this.lblPassValue = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.chkSeed = new System.Windows.Forms.CheckBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblMarkStatsText = new System.Windows.Forms.Label();
            this.pnlSelect.SuspendLayout();
            this.grpOneRoll.SuspendLayout();
            this.grpStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
     
            this.pnlSelect.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelect.Controls.Add(this.radStats);
            this.pnlSelect.Controls.Add(this.radOneRoll);
            this.pnlSelect.Controls.Add(this.lblSelect);
            this.pnlSelect.Location = new System.Drawing.Point(10, 10);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(510, 45);
            this.pnlSelect.TabIndex = 0;
            
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(5, 5);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(52, 15);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select";
            
            this.radOneRoll.AutoSize = true;
            this.radOneRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOneRoll.Location = new System.Drawing.Point(10, 23);
            this.radOneRoll.Name = "radOneRoll";
            this.radOneRoll.Size = new System.Drawing.Size(75, 19);
            this.radOneRoll.TabIndex = 1;
            this.radOneRoll.TabStop = true;
            this.radOneRoll.Text = "One Roll";
            this.radOneRoll.UseVisualStyleBackColor = true;
            this.radOneRoll.CheckedChanged += new System.EventHandler(this.radOneRoll_CheckedChanged);
           
            this.radStats.AutoSize = true;
            this.radStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStats.Location = new System.Drawing.Point(310, 23);
            this.radStats.Name = "radStats";
            this.radStats.Size = new System.Drawing.Size(86, 19);
            this.radStats.TabIndex = 2;
            this.radStats.TabStop = true;
            this.radStats.Text = "Mark Stats";
            this.radStats.UseVisualStyleBackColor = true;
            this.radStats.CheckedChanged += new System.EventHandler(this.radOneRoll_CheckedChanged);
            
            this.grpOneRoll.BackColor = System.Drawing.Color.Gainsboro;
            this.grpOneRoll.Controls.Add(this.btnClear);
            this.grpOneRoll.Controls.Add(this.btnSwapNumbers);
            this.grpOneRoll.Controls.Add(this.btnRollDice);
            this.grpOneRoll.Controls.Add(this.lblRollNameValue);
            this.grpOneRoll.Controls.Add(this.lblDice2Value);
            this.grpOneRoll.Controls.Add(this.lblDice1Value);
            this.grpOneRoll.Controls.Add(this.lblRollName);
            this.grpOneRoll.Controls.Add(this.lblDice2);
            this.grpOneRoll.Controls.Add(this.lblDice1);
            this.grpOneRoll.Controls.Add(this.lblOneRollText);
            this.grpOneRoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOneRoll.Location = new System.Drawing.Point(10, 60);
            this.grpOneRoll.Name = "grpOneRoll";
            this.grpOneRoll.Size = new System.Drawing.Size(240, 200);
            this.grpOneRoll.TabIndex = 3;
            this.grpOneRoll.TabStop = false;
            
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(155, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 35);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear One Roll";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
           
            this.btnSwapNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapNumbers.Location = new System.Drawing.Point(85, 150);
            this.btnSwapNumbers.Name = "btnSwapNumbers";
            this.btnSwapNumbers.Size = new System.Drawing.Size(65, 35);
            this.btnSwapNumbers.TabIndex = 8;
            this.btnSwapNumbers.Text = "Swap Numbers";
            this.btnSwapNumbers.UseVisualStyleBackColor = true;
            this.btnSwapNumbers.Click += new System.EventHandler(this.SwapNumbers_Click);
           
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(15, 150);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(65, 35);
            this.btnRollDice.TabIndex = 7;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            
            this.lblRollNameValue.BackColor = System.Drawing.Color.LightSalmon;
            this.lblRollNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRollNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNameValue.Location = new System.Drawing.Point(80, 105);
            this.lblRollNameValue.Name = "lblRollNameValue";
            this.lblRollNameValue.Size = new System.Drawing.Size(145, 28);
            this.lblRollNameValue.TabIndex = 6;
            this.lblRollNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblDice2Value.BackColor = System.Drawing.Color.MistyRose;
            this.lblDice2Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2Value.Location = new System.Drawing.Point(80, 75);
            this.lblDice2Value.Name = "lblDice2Value";
            this.lblDice2Value.Size = new System.Drawing.Size(50, 25);
            this.lblDice2Value.TabIndex = 5;
            this.lblDice2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            this.lblDice1Value.BackColor = System.Drawing.Color.MistyRose;
            this.lblDice1Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDice1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1Value.Location = new System.Drawing.Point(80, 45);
            this.lblDice1Value.Name = "lblDice1Value";
            this.lblDice1Value.Size = new System.Drawing.Size(50, 25);
            this.lblDice1Value.TabIndex = 4;
            this.lblDice1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            this.lblRollName.AutoSize = true;
            this.lblRollName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollName.Location = new System.Drawing.Point(12, 112);
            this.lblRollName.Name = "lblRollName";
            this.lblRollName.Size = new System.Drawing.Size(73, 15);
            this.lblRollName.TabIndex = 3;
            this.lblRollName.Text = "Roll Name:";
            
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(12, 80);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(48, 15);
            this.lblDice2.TabIndex = 2;
            this.lblDice2.Text = "Dice 2:";
            
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.Location = new System.Drawing.Point(12, 50);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(48, 15);
            this.lblDice1.TabIndex = 1;
            this.lblDice1.Text = "Dice 1:";
           
            this.lblOneRollText.AutoSize = true;
            this.lblOneRollText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneRollText.Location = new System.Drawing.Point(12, 20);
            this.lblOneRollText.Name = "lblOneRollText";
            this.lblOneRollText.Size = new System.Drawing.Size(65, 15);
            this.lblOneRollText.TabIndex = 0;
            this.lblOneRollText.Text = "One Roll";
            
            this.grpStats.BackColor = System.Drawing.Color.Gainsboro;
            this.grpStats.Controls.Add(this.lstNumbers);
            this.grpStats.Controls.Add(this.btnReset);
            this.grpStats.Controls.Add(this.btnGenerateNumbers);
            this.grpStats.Controls.Add(this.lblAverageValue);
            this.grpStats.Controls.Add(this.lblFailValue);
            this.grpStats.Controls.Add(this.lblPassValue);
            this.grpStats.Controls.Add(this.lblAverage);
            this.grpStats.Controls.Add(this.lblFail);
            this.grpStats.Controls.Add(this.lblPass);
            this.grpStats.Controls.Add(this.chkSeed);
            this.grpStats.Controls.Add(this.nudNumber);
            this.grpStats.Controls.Add(this.lblMarks);
            this.grpStats.Controls.Add(this.lblMarkStatsText);
            this.grpStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStats.Location = new System.Drawing.Point(260, 60);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(260, 200);
            this.grpStats.TabIndex = 4;
            this.grpStats.TabStop = false;
            
            this.lstNumbers.BackColor = System.Drawing.Color.White;
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(195, 45);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(55, 147);
            this.lstNumbers.TabIndex = 12;
            
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(108, 155);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 35);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset Stats";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            this.btnGenerateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateNumbers.Location = new System.Drawing.Point(15, 155);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(87, 35);
            this.btnGenerateNumbers.TabIndex = 10;
            this.btnGenerateNumbers.Text = "Generate Numbers";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);

            this.lblAverageValue.BackColor = System.Drawing.Color.MistyRose;
            this.lblAverageValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageValue.Location = new System.Drawing.Point(75, 120);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(50, 25);
            this.lblAverageValue.TabIndex = 9;
            this.lblAverageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblFailValue.BackColor = System.Drawing.Color.MistyRose;
            this.lblFailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailValue.Location = new System.Drawing.Point(75, 90);
            this.lblFailValue.Name = "lblFailValue";
            this.lblFailValue.Size = new System.Drawing.Size(50, 25);
            this.lblFailValue.TabIndex = 8;
            this.lblFailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblPassValue.BackColor = System.Drawing.Color.MistyRose;
            this.lblPassValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassValue.Location = new System.Drawing.Point(75, 60);
            this.lblPassValue.Name = "lblPassValue";
            this.lblPassValue.Size = new System.Drawing.Size(50, 25);
            this.lblPassValue.TabIndex = 7;
            this.lblPassValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(12, 125);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(58, 15);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Average:";
           
            this.lblFail.AutoSize = true;
            this.lblFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFail.Location = new System.Drawing.Point(12, 95);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(30, 15);
            this.lblFail.TabIndex = 5;
            this.lblFail.Text = "Fail:";
   
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(12, 65);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(38, 15);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Pass:";

            this.chkSeed.AutoSize = true;
            this.chkSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeed.Location = new System.Drawing.Point(134, 32);
            this.chkSeed.Name = "chkSeed";
            this.chkSeed.Size = new System.Drawing.Size(81, 17);
            this.chkSeed.TabIndex = 3;
            this.chkSeed.Text = "Seed Value";
            this.chkSeed.UseVisualStyleBackColor = true;
            this.chkSeed.CheckedChanged += new System.EventHandler(this.chkSeed_CheckedChanged);

            this.nudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber.Location = new System.Drawing.Point(75, 30);
            this.nudNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(50, 21);
            this.nudNumber.TabIndex = 2;
            this.nudNumber.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});

            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(12, 33);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(47, 15);
            this.lblMarks.TabIndex = 1;
            this.lblMarks.Text = "Marks:";

            this.lblMarkStatsText.AutoSize = true;
            this.lblMarkStatsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkStatsText.Location = new System.Drawing.Point(95, 15);
            this.lblMarkStatsText.Name = "lblMarkStatsText";
            this.lblMarkStatsText.Size = new System.Drawing.Size(76, 15);
            this.lblMarkStatsText.TabIndex = 0;
            this.lblMarkStatsText.Text = "Mark Stats";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(530, 270);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpOneRoll);
            this.Controls.Add(this.pnlSelect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 5 by Ayomide Otubaga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSelect.ResumeLayout(false);
            this.pnlSelect.PerformLayout();
            this.grpOneRoll.ResumeLayout(false);
            this.grpOneRoll.PerformLayout();
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.RadioButton radOneRoll;
        private System.Windows.Forms.RadioButton radStats;
        private System.Windows.Forms.GroupBox grpOneRoll;
        private System.Windows.Forms.Label lblOneRollText;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblRollName;
        private System.Windows.Forms.Label lblDice1Value;
        private System.Windows.Forms.Label lblDice2Value;
        private System.Windows.Forms.Label lblRollNameValue;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnSwapNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblMarkStatsText;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.CheckBox chkSeed;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblPassValue;
        private System.Windows.Forms.Label lblFailValue;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstNumbers;
    }
}