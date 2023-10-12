using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game.classes
{

    [Serializable]
    public abstract class Payment_Player : Player
    {
        protected Payment_Player(string nickname, int score, double password, string name, string familyname, int age) : base(name, familyname, age)
        {
            this.nickname = nickname;
            this.score = score;
            this.password = password;
        }

        public string nickname { get; set; }
        public int score { get; set; }
        public double password { get; set; }

        public override string ShowPicture()
        {
            return "";
        }

    }
}
