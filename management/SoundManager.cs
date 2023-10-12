using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Windows.Forms;

namespace Tetris_Game.management
{
    public class SoundManager
    {
        private SoundPlayer soundPlayer=null;

        public SoundManager()
        {
            soundPlayer = new SoundPlayer();
        }

        public void PlaySound(string soundFileName)
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            string soundFilePath = Path.Combine(executablePath, "sound", soundFileName);
            soundPlayer.SoundLocation = soundFilePath;
            soundPlayer.Play();
        }
    }
}
