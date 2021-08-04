
namespace Easytesting2
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
            this.chkbx_AlwaysOntop = new System.Windows.Forms.CheckBox();
            this.btn_Win = new System.Windows.Forms.Button();
            this.btn_Loss = new System.Windows.Forms.Button();
            this.txt_ATR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AccountValue = new System.Windows.Forms.TextBox();
            this.txt_Risk = new System.Windows.Forms.TextBox();
            this.rtxt_Output = new System.Windows.Forms.RichTextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Timer = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Losses = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Wins = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Ratio = new System.Windows.Forms.Label();
            this.lnk_Github = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // chkbx_AlwaysOntop
            // 
            this.chkbx_AlwaysOntop.AutoSize = true;
            this.chkbx_AlwaysOntop.Location = new System.Drawing.Point(12, 12);
            this.chkbx_AlwaysOntop.Name = "chkbx_AlwaysOntop";
            this.chkbx_AlwaysOntop.Size = new System.Drawing.Size(98, 17);
            this.chkbx_AlwaysOntop.TabIndex = 1;
            this.chkbx_AlwaysOntop.Text = "Always On Top";
            this.chkbx_AlwaysOntop.UseVisualStyleBackColor = true;
            this.chkbx_AlwaysOntop.CheckedChanged += new System.EventHandler(this.chkbx_AlwaysOntop_CheckedChanged);
            // 
            // btn_Win
            // 
            this.btn_Win.BackColor = System.Drawing.Color.Lime;
            this.btn_Win.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Win.FlatAppearance.BorderSize = 0;
            this.btn_Win.Location = new System.Drawing.Point(-4, 35);
            this.btn_Win.Name = "btn_Win";
            this.btn_Win.Size = new System.Drawing.Size(88, 145);
            this.btn_Win.TabIndex = 2;
            this.btn_Win.Text = "Win";
            this.btn_Win.UseVisualStyleBackColor = false;
            this.btn_Win.Click += new System.EventHandler(this.btn_Win_Click);
            // 
            // btn_Loss
            // 
            this.btn_Loss.BackColor = System.Drawing.Color.Red;
            this.btn_Loss.Location = new System.Drawing.Point(90, 35);
            this.btn_Loss.Name = "btn_Loss";
            this.btn_Loss.Size = new System.Drawing.Size(83, 145);
            this.btn_Loss.TabIndex = 3;
            this.btn_Loss.Text = "Loss";
            this.btn_Loss.UseVisualStyleBackColor = false;
            this.btn_Loss.Click += new System.EventHandler(this.btn_Loss_Click);
            // 
            // txt_ATR
            // 
            this.txt_ATR.Location = new System.Drawing.Point(251, 51);
            this.txt_ATR.Name = "txt_ATR";
            this.txt_ATR.Size = new System.Drawing.Size(116, 20);
            this.txt_ATR.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ATR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "% Risk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account Value";
            // 
            // txt_AccountValue
            // 
            this.txt_AccountValue.Location = new System.Drawing.Point(251, 106);
            this.txt_AccountValue.Name = "txt_AccountValue";
            this.txt_AccountValue.Size = new System.Drawing.Size(116, 20);
            this.txt_AccountValue.TabIndex = 10;
            // 
            // txt_Risk
            // 
            this.txt_Risk.Location = new System.Drawing.Point(251, 156);
            this.txt_Risk.Name = "txt_Risk";
            this.txt_Risk.Size = new System.Drawing.Size(116, 20);
            this.txt_Risk.TabIndex = 11;
            // 
            // rtxt_Output
            // 
            this.rtxt_Output.Location = new System.Drawing.Point(245, 191);
            this.rtxt_Output.Name = "rtxt_Output";
            this.rtxt_Output.ReadOnly = true;
            this.rtxt_Output.Size = new System.Drawing.Size(158, 75);
            this.rtxt_Output.TabIndex = 12;
            this.rtxt_Output.Text = "";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(147, 199);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(92, 67);
            this.btn_Calculate.TabIndex = 13;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Timer
            // 
            this.btn_Timer.Location = new System.Drawing.Point(116, 8);
            this.btn_Timer.Name = "btn_Timer";
            this.btn_Timer.Size = new System.Drawing.Size(130, 23);
            this.btn_Timer.TabIndex = 14;
            this.btn_Timer.Text = "Time till prevous click";
            this.btn_Timer.UseVisualStyleBackColor = true;
            this.btn_Timer.Click += new System.EventHandler(this.btn_Timer_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(8, 186);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(102, 23);
            this.btn_Undo.TabIndex = 15;
            this.btn_Undo.Text = "Undo Last Click";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wins";
            // 
            // lbl_Losses
            // 
            this.lbl_Losses.AutoSize = true;
            this.lbl_Losses.Location = new System.Drawing.Point(187, 109);
            this.lbl_Losses.Name = "lbl_Losses";
            this.lbl_Losses.Size = new System.Drawing.Size(12, 13);
            this.lbl_Losses.TabIndex = 17;
            this.lbl_Losses.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Losses";
            // 
            // lbl_Wins
            // 
            this.lbl_Wins.AutoSize = true;
            this.lbl_Wins.Location = new System.Drawing.Point(187, 68);
            this.lbl_Wins.Name = "lbl_Wins";
            this.lbl_Wins.Size = new System.Drawing.Size(12, 13);
            this.lbl_Wins.TabIndex = 19;
            this.lbl_Wins.Text = "x";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(8, 235);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 20;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ratio";
            // 
            // lbl_Ratio
            // 
            this.lbl_Ratio.AutoSize = true;
            this.lbl_Ratio.Location = new System.Drawing.Point(187, 159);
            this.lbl_Ratio.Name = "lbl_Ratio";
            this.lbl_Ratio.Size = new System.Drawing.Size(12, 13);
            this.lbl_Ratio.TabIndex = 22;
            this.lbl_Ratio.Text = "x";
            // 
            // lnk_Github
            // 
            this.lnk_Github.AutoSize = true;
            this.lnk_Github.Location = new System.Drawing.Point(374, 9);
            this.lnk_Github.Name = "lnk_Github";
            this.lnk_Github.Size = new System.Drawing.Size(63, 13);
            this.lnk_Github.TabIndex = 23;
            this.lnk_Github.TabStop = true;
            this.lnk_Github.Text = "GithubPage";
            this.lnk_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Github_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 285);
            this.Controls.Add(this.lnk_Github);
            this.Controls.Add(this.lbl_Ratio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Wins);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Losses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Timer);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.rtxt_Output);
            this.Controls.Add(this.txt_Risk);
            this.Controls.Add(this.txt_AccountValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ATR);
            this.Controls.Add(this.btn_Loss);
            this.Controls.Add(this.btn_Win);
            this.Controls.Add(this.chkbx_AlwaysOntop);
            this.Name = "Form1";
            this.Text = "EasyTesting_2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkbx_AlwaysOntop;
        private System.Windows.Forms.Button btn_Win;
        private System.Windows.Forms.Button btn_Loss;
        private System.Windows.Forms.TextBox txt_ATR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AccountValue;
        private System.Windows.Forms.TextBox txt_Risk;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Timer;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Losses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Wins;
        private System.Windows.Forms.Button btn_Reset;
        public System.Windows.Forms.RichTextBox rtxt_Output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Ratio;
        private System.Windows.Forms.LinkLabel lnk_Github;
    }
}

