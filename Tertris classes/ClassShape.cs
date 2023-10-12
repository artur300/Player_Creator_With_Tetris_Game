using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Game.Tertris_classes
{
    class ClassShape
    {
        public string id;
        public int Width;
        public int Height;
        public int[,] Dots;
        private int[,] backupDots;

        public void turn()
        {

            backupDots = Dots;
            Dots = new int[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {

                    Dots[i, j] = backupDots[Height - 1 - j, i];
                }
            }
            var temp = Width;
            Width = Height;
            Height = temp;
        }

        public void rollback()
        {
            Dots = backupDots;

            var temp = Width;
            Width = Height;
            Height = temp;
        }

    }
}
