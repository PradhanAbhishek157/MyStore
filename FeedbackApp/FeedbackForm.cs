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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        //Saving Feedbacks to Text File
        private void btnSave_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            try
            {
                f.CustomerName = txtCustomerName.Text;
                f.PhoneNumber = txtPhoneNumber.Text;
                f.Email = txtEmail.Text;
                f.FoodQuality = int.Parse(cmbBoxFoodQuality.Text);
                f.StaffFriendliness = int.Parse(cmbBoxStaffFriendliness.Text);
                f.Cleanliness = int.Parse(cmbBoxCleanliness.Text);
                f.OrderAccuracy = int.Parse(cmbBoxOrderAccuracy.Text);
                f.ResturantAmbince = int.Parse(cmbBoxRestaurantAmbiance.Text);
                f.ValueForMoney = int.Parse(cmbBoxValueForMoney.Text);
                f.Suggestions = txtSuggestion.Text;

                if (txtCustomerName.Text != "" && txtPhoneNumber.Text != "" && txtEmail.Text != "" &&  cmbBoxFoodQuality.Text != "" && cmbBoxStaffFriendliness.Text != "" && cmbBoxCleanliness.Text != "" && cmbBoxOrderAccuracy.Text != "" && cmbBoxRestaurantAmbiance.Text != "" && cmbBoxValueForMoney.Text != "" && txtSuggestion.Text != "")
                {

                    string dat = DateTime.Now.ToString("MM/dd/yyyy");
                    f.Date = dat;

                    string tim = DateTime.Now.ToString("h:mm tt");
                    f.Time = tim;
                }


                string flag = f.Save(f);
                {
                    MessageBox.Show("Your review is saved", "Info");
                    ClearForm();
                }
            }
            catch
            {
                MessageBox.Show("You cannot leave any crieteria empty. Please fill all the crieteria", "Error");
            }
        }

        public void ClearForm()
        {
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
            cmbBoxFoodQuality.Items.Clear();
            cmbBoxStaffFriendliness.Items.Clear();
            cmbBoxCleanliness.Items.Clear();
            cmbBoxOrderAccuracy.Items.Clear();
            cmbBoxRestaurantAmbiance.Items.Clear();
            cmbBoxValueForMoney.Items.Clear();
            txtSuggestion.Text = "";
        }

        private void Suggestion_Click(object sender, MouseEventArgs e)
        {
            txtSuggestion.Clear();
        }
    }
}
