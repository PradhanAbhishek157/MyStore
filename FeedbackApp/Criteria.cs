using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackApp
{
    public partial class Criteria : Form
    {
        public Criteria()
        {
            InitializeComponent();
            ReadFromTextFile(_path);
        }

        private string _path = "Criteria.txt";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddCriteria.Text == "")
            {
                MessageBox.Show("Cannot add empty item in criteria", "Error");
            }
            else
            {
                WriteToTextFile(_path);
            }
        }

        private void WriteToTextFile(string _path, bool append = true)
        {
            StreamWriter sw = new StreamWriter(_path, append);
            sw.WriteLine(txtAddCriteria.Text);
            Clear();
            MessageBox.Show("New Criteria Added", "Info");
            sw.Close();
        }

        private void ReadFromTextFile(string _path)
        {
            StreamReader r = new StreamReader(_path);
            txtCriteriaList.Text = r.ReadToEnd();
            r.Close();
        }

        private void Clear()
        {
            txtAddCriteria.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ReadFromTextFile(_path);
        }
    }
}
