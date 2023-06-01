namespace _18._1ugrik
{
    public partial class Formugartas : Form
    {
        public Formugartas()
        {
            InitializeComponent();
        }

        private void btnbalrafel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnjobbrafel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width-Width;
            Top = 0;
        }

        private void btnbalralent_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top= Screen.PrimaryScreen.Bounds.Height-Height;
        }

        private void btnjobbralnet_Click(object sender, EventArgs e)
        {
            Left= Screen.PrimaryScreen.Bounds.Width-Width;
            Top= Screen.PrimaryScreen.Bounds.Height-Height;
        }
    }
}