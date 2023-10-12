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
    public partial class Creditcard_registration : UserControl
    {
        private SoundManager soundPlayer;
        BindingList<Credit_players> credit_users;
        public Creditcard_registration(BindingList<Credit_players> credit_users)
        {
            InitializeComponent();
            this.credit_users = credit_users;
            soundPlayer = new SoundManager();
        }

        private void Confirm_Click(object sender, EventArgs e)
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

            string nickname = textnickname.Text;
            if (string.IsNullOrWhiteSpace(nickname))
            {
                MessageBox.Show("Please enter a valid nickname.");
                return;
            }

            double password;
            if (!double.TryParse(textpassword.Text, out password))
            {
                MessageBox.Show("Please enter a valid password.");
                return;
            }

            double ID;
            if (!double.TryParse(textid.Text, out ID))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            double creditcard;
            if (!double.TryParse(textCreditcard.Text, out creditcard))
            {
                MessageBox.Show("Please enter a valid credit card number.");
                return;
            }

            Credit_players playerCard = new Credit_players(nickname, 0, password, name, familyname, age, creditcard, ID);
            PlayerManager.AddPerson(playerCard);
            credit_users.Add(playerCard);


            textname.Text = "";
            textfamilyname.Text = "";
            textage.Text = "";
            textnickname.Text = "";
            textpassword.Text = "";
            textid.Text = "";
            textCreditcard.Text = "";

            MessageBox.Show("User was added");
        }
    }
}
