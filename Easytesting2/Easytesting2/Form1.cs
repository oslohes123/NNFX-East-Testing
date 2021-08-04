using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections;


namespace Easytesting2
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();

        enum TradeOutcome
        {
            Win,
            Loss
        }

        int wins = 0;
        int losses = 0;
        Stack<TradeOutcome> Trades = new Stack<TradeOutcome>();
        public Form1()
        {
            InitializeComponent();
        }

        private void chkbx_AlwaysOntop_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (txt_AccountValue.Text.Length == 0 || txt_ATR.Text.Length == 0 || txt_Risk.Text.Length == 0)
            {
                MessageBox.Show("Make sure to enter data into all three of the boxes");
                resettxtboxes();
            }
            else if (txt_AccountValue.Text.Any(char.IsLetter) || txt_ATR.Text.Any(char.IsLetter) || txt_Risk.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Make sure to enter numbers into each of the fields and nothing else for the thing to work properly");
                resettxtboxes();

            }
            else
            {
                double ATR = Convert.ToDouble(txt_ATR.Text);
                double AccountValue = Convert.ToDouble(txt_AccountValue.Text);
                double Risk = AccountValue * (Convert.ToDouble(txt_Risk.Text)/100) ;

                double StopLoss = ATR * 1.5;
                double TakeProfit = ATR;
                double dollersperpip = Risk / StopLoss;
                rtxt_Output.Text = $"Stop Loss: {StopLoss}\nTake Profit: {TakeProfit} \nDollers Per Pip: {dollersperpip.ToString("N3")} \nHalf of that is: {(dollersperpip/2).ToString("N3")}";


            }
        }

        private void resettxtboxes() {
            txt_AccountValue.Text = "";
            txt_ATR.Text = "";
            txt_Risk.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkbx_AlwaysOntop.Checked = true;
            this.TopMost = true;
        }

        private void btn_Win_Click(object sender, EventArgs e)
        {
            wins++;
            stopwatch.Restart();
            Trades.Push(TradeOutcome.Win);
            UpdateLabels();
        }
     

        private void btn_Loss_Click(object sender, EventArgs e)
        {
            losses++;
            stopwatch.Restart();
            Trades.Push(TradeOutcome.Loss);
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            lbl_Wins.Text = $"{wins}";
            lbl_Losses.Text = $"{losses}";
        }

        private void btn_Timer_Click(object sender, EventArgs e)
        {
            if(stopwatch.IsRunning == false)
            {
                MessageBox.Show("The stopwatch was not running");
            }
            else
            {
                string message;
                TimeSpan ts = stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
              ts.Hours, ts.Minutes, ts.Seconds,
              ts.Milliseconds / 10);

                if (Trades.Peek() == TradeOutcome.Win)
                {
                    message = $"{elapsedTime} and the last button was a win";
                }
                else
                {
                    message = $"{elapsedTime} and the last button was a loss";

                }
                MessageBox.Show(message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string output = $"Wins: {wins} Losses: {losses} at this time {DateTime.Now.ToString("G")}";
            using (StreamWriter sw = new StreamWriter("Data.txt", append: true))
            {
                sw.WriteLine(output);
            }
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            wins = 0;
            losses = 0;
            UpdateLabels();
            Trades.Clear();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if(Trades.Count == 0)
            {
                MessageBox.Show("No more trades to go back");
            }
            else if(Trades.Peek() == TradeOutcome.Win)
            {
                wins--;
                stopwatch.Restart();
                UpdateLabels();
                Trades.Pop();
                stopwatch.Stop();
                stopwatch.Reset();
            }
            else if(Trades.Peek() == TradeOutcome.Loss)
            {
                losses--;
                stopwatch.Restart();
                UpdateLabels();
                Trades.Pop();
                stopwatch.Reset();
            }

        }
    }
    
}
