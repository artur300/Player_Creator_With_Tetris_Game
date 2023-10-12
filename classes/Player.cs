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
    public abstract class Player
    {
        public Player(string name, string familyname, int age)
        {
            this.name = name;
            this.familyname = familyname;
            this.age = age;
        }

        public string name { get; set; }
        public int age { get; set; }
        public string familyname { get; set; }

        public virtual string ShowPicture()
        {
            return "";
        }
    }
}
