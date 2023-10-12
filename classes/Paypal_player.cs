using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_Game.classes
{

    [Serializable]
    public class Paypal_player : Payment_Player
    {

        public Paypal_player(string nickname, int score, double password, string name, string familyname, int age, string paypal_username, double paypal_id)
   : base(nickname, score, password, name, familyname, age)
        {
            this.paypal_username = paypal_username;
            this.paypal_id = paypal_id;

        }

        public string paypal_username { get; set; }
        public double paypal_id { get; set; }


        public override string ShowPicture()
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            string imageFilePath = Path.Combine(executablePath, "pic", "ninja.jpg");

            if (File.Exists(imageFilePath))
            {
                return imageFilePath;
            }
            else
            {
                Console.WriteLine("Image file not found. Using default image.");
                return Path.Combine(executablePath, "pic", "default.jpg");
            }
        }



    }
}
