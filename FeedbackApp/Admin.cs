using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackApp
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void toolLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void toolAddCriteria_Click(object sender, EventArgs e)
        {
            new Criteria().Show();
        }

        private void toolEnterFeedback_Click(object sender, EventArgs e)
        {
            new FeedbackForm().Show();
        }

        private void toolChartReport_Click(object sender, EventArgs e)
        {
            new ChartReport().Show();
        }

        private void toolReport_Click(object sender, EventArgs e)
        {
            new Report().Show();
        }
    }
}
