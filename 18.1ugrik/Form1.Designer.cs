namespace _18._1ugrik
{
    partial class Formugartas
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
            this.btnbalrafel = new System.Windows.Forms.Button();
            this.btnjobbrafel = new System.Windows.Forms.Button();
            this.btnbalralent = new System.Windows.Forms.Button();
            this.btnjobbralnet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbalrafel
            // 
            this.btnbalrafel.BackColor = System.Drawing.Color.Pink;
            this.btnbalrafel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbalrafel.Location = new System.Drawing.Point(131, 72);
            this.btnbalrafel.Name = "btnbalrafel";
            this.btnbalrafel.Size = new System.Drawing.Size(156, 23);
            this.btnbalrafel.TabIndex = 0;
            this.btnbalrafel.Text = "balra fel";
            this.btnbalrafel.UseVisualStyleBackColor = false;
            this.btnbalrafel.Click += new System.EventHandler(this.btnbalrafel_Click);
            // 
            // btnjobbrafel
            // 
            this.btnjobbrafel.BackColor = System.Drawing.Color.Pink;
            this.btnjobbrafel.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnjobbrafel.Location = new System.Drawing.Point(379, 72);
            this.btnjobbrafel.Name = "btnjobbrafel";
            this.btnjobbrafel.Size = new System.Drawing.Size(134, 23);
            this.btnjobbrafel.TabIndex = 1;
            this.btnjobbrafel.Text = "Jobbra fel";
            this.btnjobbrafel.UseVisualStyleBackColor = false;
            this.btnjobbrafel.Click += new System.EventHandler(this.btnjobbrafel_Click);
            // 
            // btnbalralent
            // 
            this.btnbalralent.BackColor = System.Drawing.Color.Pink;
            this.btnbalralent.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbalralent.Location = new System.Drawing.Point(131, 205);
            this.btnbalralent.Name = "btnbalralent";
            this.btnbalralent.Size = new System.Drawing.Size(156, 23);
            this.btnbalralent.TabIndex = 2;
            this.btnbalralent.Text = "balra lent";
            this.btnbalralent.UseVisualStyleBackColor = false;
            this.btnbalralent.Click += new System.EventHandler(this.btnbalralent_Click);
            // 
            // btnjobbralnet
            // 
            this.btnjobbralnet.BackColor = System.Drawing.Color.Pink;
            this.btnjobbralnet.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnjobbralnet.Location = new System.Drawing.Point(366, 193);
            this.btnjobbralnet.Name = "btnjobbralnet";
            this.btnjobbralnet.Size = new System.Drawing.Size(134, 23);
            this.btnjobbralnet.TabIndex = 3;
            this.btnjobbralnet.Text = "jobbra lent";
            this.btnjobbralnet.UseVisualStyleBackColor = false;
            this.btnjobbralnet.Click += new System.EventHandler(this.btnjobbralnet_Click);
            // 
            // Formugartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjobbralnet);
            this.Controls.Add(this.btnbalralent);
            this.Controls.Add(this.btnjobbrafel);
            this.Controls.Add(this.btnbalrafel);
            this.Name = "Formugartas";
            this.Text = "Formugratas";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnbalrafel;
        private Button btnjobbrafel;
        private Button btnbalralent;
        private Button btnjobbralnet;
    }
}