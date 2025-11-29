using System;
using System.Windows.Forms;

namespace Lab5
{
    /*
     * Name: Ayomide Otubaga
     * GitHub Repo: https://github.com/ayomideotubaga/otubagalab_5
     */
    
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radOneRoll.Checked = true;
            this.Text = this.Text + " - Ayomide Otubaga";
            
            grpOneRoll.Visible = true;
            grpStats.Visible = false;

            ClearOneRoll();
            ClearStats();
        }

        private void radOneRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (radOneRoll.Checked)
            {
                grpOneRoll.Visible = true;
                grpStats.Visible = false;
                ClearOneRoll();
            }
            else
            {
                grpOneRoll.Visible = false;
                grpStats.Visible = true;
                ClearStats();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOneRoll();
        }

        private void ClearOneRoll()
        {
            lblDice1Value.Text = "";
            lblDice2Value.Text = "";
            lblRollNameValue.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearStats();
        }

        private void ClearStats()
        {
            lblAverageValue.Text = "";
            lblPassValue.Text = "";
            lblFailValue.Text = "";
            lstNumbers.Items.Clear();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1 = RollDice();
            int dice2 = RollDice();
            
            lblDice1Value.Text = dice1.ToString();
            lblDice2Value.Text = dice2.ToString();
            
            string rollName = GetName(dice1, dice2);
            lblRollNameValue.Text = rollName;
        }

        private int RollDice()
        {
            return rand.Next(1, 7);
        }

        private string GetName(int die1, int die2)
        {
            int total = die1 + die2;
            
            if (die1 == 1 && die2 == 1) return "Snake Eyes";
            if (die1 == 6 && die2 == 6) return "Box Cars";
            if (total == 7 || total == 11) return "Natural";
            if (total == 2 || total == 3 || total == 12) return "Craps";
            
            return "Points";
        }

        private void SwapNumbers_Click(object sender, EventArgs e)
        {
            bool data1 = DataPresent(lblDice1Value);
            bool data2 = DataPresent(lblDice2Value);
            
            if (!data1 || !data2)
            {
                MessageBox.Show("Need data in both labels to swap");
                return;
            }
            
            string temp1 = lblDice1Value.Text;
            string temp2 = lblDice2Value.Text;
            
            SwapData(ref temp1, ref temp2);
            
            lblDice1Value.Text = temp1;
            lblDice2Value.Text = temp2;
        }

        private bool DataPresent(Label lbl)
        {
            return !string.IsNullOrEmpty(lbl.Text);
        }

        private void SwapData(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }

        private void chkSeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeed.Checked)
            {
                DialogResult res = MessageBox.Show("Use seed value?", "Seed", 
                    MessageBoxButtons.YesNo);
                
                if (res == DialogResult.No)
                {
                    chkSeed.Checked = false;
                }
            }
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            int count = (int)nudNumber.Value;
            int[] marks = new int[count];
            
            if (chkSeed.Checked)
            {
                rand = new Random(1000);
            }
            else
            {
                rand = new Random(); 
            }
            
            lstNumbers.Items.Clear();
            
            int i = 0;
            while (i < count)
            {
                marks[i] = rand.Next(40, 101); 
                i++;
            }
            
            double avg;
            int pass, fail;
            CalcStats(marks, out avg, out pass, out fail);
            
            lblAverageValue.Text = avg.ToString("F2");
            lblPassValue.Text = pass.ToString();
            lblFailValue.Text = fail.ToString();
            
            foreach (int m in marks)
            {
                lstNumbers.Items.Add(m.ToString());
            }
        }

        private void CalcStats(int[] numbers, out double average, out int pass, out int fail)
        {
            int total = 0;
            pass = 0;
            fail = 0;
            
            foreach (int num in numbers)
            {
                total += num;
                if (num >= 50) 
                    pass++;
                else 
                    fail++;
            }
            
            if (numbers.Length > 0)
                average = (double)total / numbers.Length;
            else
                average = 0;
        }
    }
}