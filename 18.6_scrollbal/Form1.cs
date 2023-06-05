namespace _18._6_scrollbal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sb_kek_ValueChanged(object sender, EventArgs e)
        {
            lb_negyzet.BackColor = Color.FromArgb(sb_piros.Value,
          sb_zold.Value, sb_kek.Value);
        }

        private void sb_piros_ValueChanged(object sender, EventArgs e)
        {
            lb_negyzet.BackColor = Color.FromArgb(sb_piros.Value,
            sb_zold.Value, sb_kek.Value);
        }

        private void sb_zold_ValueChanged(object sender, EventArgs e)
        {
            lb_negyzet.BackColor = Color.FromArgb(sb_piros.Value,
          sb_zold.Value, sb_kek.Value);
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            lb_negyzet.Width = lb_negyzet.Height = hScrollBar.Value;
            label5.Text = hScrollBar.Value.ToString();
        }
    }
}