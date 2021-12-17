using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp
{
    class Feedback
    {
        private string _path = "Feedback.txt";

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int FoodQuality { get; set; }

        public int StaffFriendliness { get; set; }

        public int Cleanliness { get; set; }

        public int OrderAccuracy { get; set; }

        public int ResturantAmbince { get; set; }

        public int ValueForMoney { get; set; }

        public string Suggestions { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        //Serializing the feedbacks in text file in Json Format.
        public string Save(Feedback data)
        {
            string str = JsonConvert.SerializeObject(data, Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
        }

        //Deserializing the feedback and saving in a List
        public List<Feedback> List()
        {
            string d = Utility.ReadFromTextFile(_path);
            if (d != null)
            {
                List<Feedback> lst = JsonConvert.DeserializeObject<List<Feedback>>(d);
                return lst;
            }
            return null;
        }
    }
}
