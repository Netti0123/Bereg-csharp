namespace _18._2szovegigazitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sz�veg_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (sz�veg.Width / 3);
            int m = e.Y / (sz�veg.Height / 3);
            switch (m * 3 + n)
            { 
                case 0: sz�veg.TextAlign = ContentAlignment.TopLeft; break;
                case 1: sz�veg.TextAlign = ContentAlignment.TopCenter; break;
                case 2: sz�veg.TextAlign = ContentAlignment.TopRight; break;
                case 3: sz�veg.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: sz�veg.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: sz�veg.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: sz�veg.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: sz�veg.TextAlign = ContentAlignment.BottomCenter; break; 
                case 8: sz�veg.TextAlign = ContentAlignment.BottomRight; break;



            }
        }
    }
}