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
            btnHome.BringToFront();
            btnCreate.BringToFront();
            btnOngoing.BringToFront();
            btnInfo.BringToFront();
            panel1.BringToFront();
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
            panelTab.Left = btnHome.Left;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnCreate.Width;
            panelTab.Left = btnCreate.Left;
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnOngoing.Width;
            panelTab.Left = btnOngoing.Left;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelTab.Width = btnInfo.Width;
            panelTab.Left = btnInfo.Left;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}