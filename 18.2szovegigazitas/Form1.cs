namespace _18._2szovegigazitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szöveg_MouseClick(object sender, MouseEventArgs e)
        {
            int n = e.X / (szöveg.Width / 3);
            int m = e.Y / (szöveg.Height / 3);
            switch (m * 3 + n)
            { 
                case 0: szöveg.TextAlign = ContentAlignment.TopLeft; break;
                case 1: szöveg.TextAlign = ContentAlignment.TopCenter; break;
                case 2: szöveg.TextAlign = ContentAlignment.TopRight; break;
                case 3: szöveg.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: szöveg.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: szöveg.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: szöveg.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: szöveg.TextAlign = ContentAlignment.BottomCenter; break; 
                case 8: szöveg.TextAlign = ContentAlignment.BottomRight; break;



            }
        }
    }
}