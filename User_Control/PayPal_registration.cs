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
    public partial class PayPal_registration : UserControl
    {
        private SoundManager soundPlayer;
        BindingList<Paypal_player> PayPal_users;

        public PayPal_registration(BindingList<Paypal_player> PayPal_users)
        {
            InitializeComponent();
            this.PayPal_users = PayPal_users;
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

            double PayPal_ID;
            if (!double.TryParse(textPayPalID.Text, out PayPal_ID))
            {
                MessageBox.Show("Please enter a valid PayPal ID.");
                return;
            }

            string PayPal_username = textPayPalusername.Text;
            if (string.IsNullOrWhiteSpace(PayPal_username))
            {
                MessageBox.Show("Please enter a valid PayPal username.");
                return;
            }


            Paypal_player playerPayPal = new Paypal_player(nickname, 0, password, name, familyname, age, PayPal_username, PayPal_ID);
            PlayerManager.AddPerson(playerPayPal);
            PayPal_users.Add(playerPayPal);


            textname.Text = "";
            textfamilyname.Text = "";
            textage.Text = "";
            textnickname.Text = "";
            textpassword.Text = "";
            textPayPalID.Text = "";
            textPayPalusername.Text = "";

            MessageBox.Show("User was edded");
        }
    }
}
