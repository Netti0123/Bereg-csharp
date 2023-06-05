using System;

namespace _18._4mozgat
{
    public partial class Form1 : Form
    {
        private int meretezo = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void növekszik_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.1;
        }

        private void csökken_Click(object sender, EventArgs e)
        {
             Width -= meretezo;
            Height -= meretezo;
        }

        private void középre_Click(object sender, EventArgs e)
        {
        Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2; 
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            le.Visible = teljesen1.Visible =
            fel.Visible = teljesen.Visible =
            balra.Visible = teljesenb.Visible =
            jobbra.Visible = teljesenj.Visible = true;
        }

        private void fel_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0) 
            { 
                Top -= meretezo;
            } 
            else { Top = 0;
           fel.Visible = teljesen.Visible = false; }
            le.Visible = teljesen1.Visible = true;
        }

        private void teljesen_Click(object sender, EventArgs e)
        {
            Top = 0;
            fel.Visible = teljesen.Visible = false;
            le.Visible = teljesen1.Visible = true;
        }

        private void le_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0)
            {
                Top += meretezo;
            }
            else
            {
                Top = 0;
                le.Visible= teljesen1.Visible = false;
            }
            fel.Visible = teljesen.Visible = true;
        }
    }
 
}