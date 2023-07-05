using System.Collections.Generic;
using System.Windows.Forms;

namespace Camping
{
    public partial class ReservationsPage : Form
    {
        public List<string[]> csvData;

        public ReservationsPage()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var aboutPage = new AboutBox1();
            this.Hide();
            aboutPage.Show();
        }

        private void importToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var importPage = new Import();
            this.Hide();
            importPage.Show();  
        }
    }
}

