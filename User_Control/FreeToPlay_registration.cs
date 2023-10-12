using System;
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
    public partial class FreeToPlay_registration : UserControl
    {
        private SoundManager soundPlayer;
        BindingList<FreeToPlay_players> free_users;
        public FreeToPlay_registration(BindingList<FreeToPlay_players> free_users)
        {
            InitializeComponent();
            this.free_users =free_users;
            soundPlayer = new SoundManager();
        }

        private void Confirm_Click(object sender, System.EventArgs e)
        {

            soundPlayer.PlaySound("butten.wav");
            string name = textname.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }

            string familyname = textfamilyname.Text;
            if (string.IsNullOrWhiteSpace(familyname))
            {
                MessageBox.Show("Please enter a valid family name.");
                return;
            }

            int age;
            if (!Int32.TryParse(textage.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            int coins=3;
            int gamesPlayed=0;
          

            FreeToPlay_players freeplayer = new FreeToPlay_players(name,familyname,age,coins, gamesPlayed);
            PlayerManager.AddPerson(freeplayer);
            free_users.Add(freeplayer);


            textname.Text = "";
            textfamilyname.Text = "";
            textage.Text = "";
           

            MessageBox.Show("User was added");
        }
    }
}
