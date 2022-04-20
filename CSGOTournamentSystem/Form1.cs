namespace CSGOTournamentSystem
{
    public partial class CTM : Form
    {
        public CTM()
        {
            InitializeComponent();
            StartHide();
            StartFront();
        }

        public void StartHide()
        {
            alert.Hide();
        }
        public void StartFront()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(textBox1.Text) && !ListNames.Items.Contains(textBox1.Text) && textBox1.TextLength >= 2 && textBox1.TextLength <= 32)
            //{
            //    ListNames.Items.Add(textBox1.Text);
            //    return;
            //}
            //alert.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnHome.Width;
            panelTab.Top = btnHome.Top;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnCreate.Width;
            panelTab.Top = btnCreate.Top;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnActive.Width;
            panelTab.Top = btnActive.Top;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnInfo.Width;
            panelTab.Top = btnInfo.Top;
        }
    }
}