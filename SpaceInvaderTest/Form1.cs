namespace SpaceInvaderTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int sum = Int32.Parse(txtA.Text) * Int32.Parse(txtB.Text);
            lTotal.Text = sum.ToString();
        }
    }
}
