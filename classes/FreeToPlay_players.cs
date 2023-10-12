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
    public class FreeToPlay_players:Player
    {
        public FreeToPlay_players(string name, string familyname, int age,int coins, int gamesPlayed) :base(name, familyname, age)
        {
            this.Coins = coins;
            this.GamesPlayed = gamesPlayed;
        }

        public int Coins { get; set; }
        public int GamesPlayed { get; set; }

        public override string ShowPicture()
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            string imageFilePath = Path.Combine(executablePath, "pic", "croc.jpg");
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

        public void PlayGame()
        {
            if (Coins > 0)
            {
                Coins--;
                GamesPlayed++;
                Console.WriteLine($"{name} played a game. Coins left: {Coins}");
            }
            else
            {
                Console.WriteLine($"{name} doesn't have enough coins to play.");
            }
        }

        public bool CanPlayMoreGames()
        {
            return Coins > 0;
        }

       



    }
}
