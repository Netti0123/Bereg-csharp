namespace _18._7_forgatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb_bal_Click(object sender, EventArgs e)
        {
            Image s = lb_1.BackgroundImage;
            lb_1.BackgroundImage = lb_2.BackgroundImage;
            lb_2.BackgroundImage = lb_3.BackgroundImage;
            lb_3.BackgroundImage = lb_4.BackgroundImage;
            lb_4.BackgroundImage = lb_5.BackgroundImage;
            lb_5.BackgroundImage = lb_6.BackgroundImage;
            lb_6.BackgroundImage = lb_7.BackgroundImage;
            lb_7.BackgroundImage = lb_8.BackgroundImage;
            lb_8.BackgroundImage = s;
        }

        private void pb_jobb_Click(object sender, EventArgs e)
        {
            Image s = lb_8.BackgroundImage;
            lb_8.BackgroundImage = lb_7.BackgroundImage;
            lb_7.BackgroundImage = lb_6.BackgroundImage;
            lb_6.BackgroundImage = lb_5.BackgroundImage;
            lb_5.BackgroundImage = lb_4.BackgroundImage;
            lb_4.BackgroundImage = lb_3.BackgroundImage;
            lb_3.BackgroundImage = lb_2.BackgroundImage;
            lb_2.BackgroundImage = lb_1.BackgroundImage;
            lb_1.BackgroundImage = s;
        }
    }
}