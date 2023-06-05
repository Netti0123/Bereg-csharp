namespace _18._6_scrollbal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.sb_piros = new System.Windows.Forms.HScrollBar();
            this.sb_kek = new System.Windows.Forms.HScrollBar();
            this.sb_zold = new System.Windows.Forms.HScrollBar();
            this.lb_negyzet = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(131, 25);
            this.hScrollBar.Maximum = 309;
            this.hScrollBar.Minimum = 10;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(488, 23);
            this.hScrollBar.TabIndex = 0;
            this.hScrollBar.Value = 309;
            this.hScrollBar.ValueChanged += new System.EventHandler(this.hScrollBar_ValueChanged);
            // 
            // sb_piros
            // 
            this.sb_piros.Location = new System.Drawing.Point(131, 391);
            this.sb_piros.Name = "sb_piros";
            this.sb_piros.Size = new System.Drawing.Size(488, 21);
            this.sb_piros.TabIndex = 1;
            this.sb_piros.ValueChanged += new System.EventHandler(this.sb_piros_ValueChanged);
            // 
            // sb_kek
            // 
            this.sb_kek.Location = new System.Drawing.Point(131, 431);
            this.sb_kek.Name = "sb_kek";
            this.sb_kek.Size = new System.Drawing.Size(488, 21);
            this.sb_kek.TabIndex = 2;
            this.sb_kek.ValueChanged += new System.EventHandler(this.sb_kek_ValueChanged);
            // 
            // sb_zold
            // 
            this.sb_zold.Location = new System.Drawing.Point(131, 469);
            this.sb_zold.Name = "sb_zold";
            this.sb_zold.Size = new System.Drawing.Size(488, 21);
            this.sb_zold.TabIndex = 3;
            this.sb_zold.ValueChanged += new System.EventHandler(this.sb_zold_ValueChanged);
            // 
            // lb_negyzet
            // 
            this.lb_negyzet.BackColor = System.Drawing.Color.Snow;
            this.lb_negyzet.Location = new System.Drawing.Point(291, 72);
            this.lb_negyzet.Name = "lb_negyzet";
            this.lb_negyzet.Size = new System.Drawing.Size(133, 124);
            this.lb_negyzet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "PIROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "KÉK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "ZÖLD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(131, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Oldal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_negyzet);
            this.Controls.Add(this.sb_zold);
            this.Controls.Add(this.sb_kek);
            this.Controls.Add(this.sb_piros);
            this.Controls.Add(this.hScrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar hScrollBar;
        private HScrollBar sb_piros;
        private HScrollBar sb_kek;
        private HScrollBar sb_zold;
        private Panel lb_negyzet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}