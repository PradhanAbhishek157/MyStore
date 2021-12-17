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
    public partial class ChartReport : Form
    {
        public ChartReport()
        {
            InitializeComponent();
        }

        private void btnUpdateChart_Click(object sender, EventArgs e)
        {
            int count = gridViewFeedback.RowCount;
            count = count - 1;
            this.chart1.Series["Total"].Points.AddXY("Total", count);
        }
    }
}
