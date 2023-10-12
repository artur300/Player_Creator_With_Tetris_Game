using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris_Game.classes;
using Tetris_Game.management;

namespace Tetris_Game.User_Control
{
    public partial class PlayerPictureForm : UserControl
    {

        public PlayerPictureForm()
        {
            InitializeComponent();

        }

        public void SetPlayerPicture(Player player)
        {
            string imagePath = player.ShowPicture();

            if (!string.IsNullOrEmpty(imagePath))
            {
                pictureBox1.ImageLocation = imagePath;
            }
            else
            {
                pictureBox1.Image = null;
            }

            if (player is FreeToPlay_players freePlayer)
            {
                label1.Text = freePlayer.name;
                label2.Text = string.Empty;
            }
            else if (player is Payment_Player regularPlayer)
            {
                label1.Text = regularPlayer.nickname;
                label2.Text = $"Score: {regularPlayer.score}";
            }
        }
    }
   
}
