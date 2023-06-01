namespace _18._2szovegigazitas
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
            this.szöveg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szöveg
            // 
            this.szöveg.AutoSize = true;
            this.szöveg.BackColor = System.Drawing.Color.Pink;
            this.szöveg.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.szöveg.Location = new System.Drawing.Point(174, 122);
            this.szöveg.Name = "szöveg";
            this.szöveg.Size = new System.Drawing.Size(257, 30);
            this.szöveg.TabIndex = 0;
            this.szöveg.Text = "ha a feliratra adott teruletere \r\nkattint akkor oda igazitom a szovget";
            this.szöveg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.szöveg_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szöveg);
            this.Name = "Form1";
            this.Text = "Ha a terület";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label szöveg;
    }
}