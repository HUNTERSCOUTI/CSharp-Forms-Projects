namespace CSGOTournamentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !lstNames.Items.Contains(textBox1.Text))
            lstNames.Items.Add(textBox1.Text);
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}