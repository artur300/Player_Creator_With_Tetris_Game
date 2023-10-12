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
    public class Credit_players : Payment_Player
    {
        public Credit_players(string nickname, int score, double password, string name, string familyname, int age, double creditcard, double ID)
    : base(nickname, score, password, name, familyname, age)
        {
            this.creditcard = creditcard;
            this.ID = ID;

        }

        public double creditcard { get; set; }
        public double ID { get; set; }


       

        public override string ShowPicture()
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            string imageFilePath = Path.Combine(executablePath, "pic", "rhino.jpg");
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
