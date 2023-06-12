namespace _18._9_matrix
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add meg a matrix méretét";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Eredmenyek";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mehet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(226, 70);
            this.a.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.a.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(120, 23);
            this.a.TabIndex = 5;
            this.a.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(392, 68);
            this.b.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.b.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(120, 23);
            this.b.TabIndex = 6;
            this.b.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(565, 121);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(143, 324);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Location = new System.Drawing.Point(33, 121);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(479, 324);
            this.dataGridView.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Button button1;
        private NumericUpDown a;
        private NumericUpDown b;
        private RichTextBox richTextBox;
        private DataGridView dataGridView;
    }
}