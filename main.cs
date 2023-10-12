using System;
using System.ComponentModel;
using System.Windows.Forms;
using Tetris_Game.classes;
using Tetris_Game.management;
using Tetris_Game.User_Control;
using System.Media;
using System.IO;

namespace Tetris_Game
{
    public partial class main : Form
    {
        private SoundManager soundManager;
        private PlayerPictureForm avatarControl;

        public main()
        {
            InitializeComponent();
            PickPlayertype.Items.Add("Credit Card payment user");
            PickPlayertype.Items.Add("PayPal payment user");
            PickPlayertype.Items.Add("Free to play user");


            soundManager = new SoundManager();
            avatarControl = new PlayerPictureForm(); 
            ResigtrationPanel.Controls.Add(avatarControl);
            avatarControl.Visible = false;
        }



        private void PickPlayertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResigtrationPanel.Controls.Clear();
            if (PickPlayertype.SelectedIndex == 0)
            {
                BindingList<Credit_players> credit_users = PlayerManager.GetItemsFromList<Credit_players>();
                ResigtrationPanel.Controls.Add(new Creditcard_registration(credit_users));
                dataGridView1.DataSource = credit_users;

                dataGridView1.Columns["name"].DisplayIndex = 0;
                dataGridView1.Columns["familyname"].DisplayIndex = 1;
                dataGridView1.Columns["age"].DisplayIndex = 2;
                dataGridView1.Columns["nickname"].DisplayIndex = 3;
                dataGridView1.Columns["password"].DisplayIndex = 4;
                dataGridView1.Columns["ID"].DisplayIndex = 5;
                dataGridView1.Columns["creditcard"].DisplayIndex = 6;

            }
            else if (PickPlayertype.SelectedIndex == 1)
            {
                BindingList<Paypal_player> PayPal_users = PlayerManager.GetItemsFromList<Paypal_player>();
                ResigtrationPanel.Controls.Add(new PayPal_registration(PayPal_users));
                dataGridView1.DataSource = PayPal_users;

                dataGridView1.Columns["name"].DisplayIndex = 0;
                dataGridView1.Columns["familyname"].DisplayIndex = 1;
                dataGridView1.Columns["age"].DisplayIndex = 2;
                dataGridView1.Columns["nickname"].DisplayIndex = 3;
                dataGridView1.Columns["password"].DisplayIndex = 4;
                dataGridView1.Columns["PayPal_ID"].DisplayIndex = 5;
                dataGridView1.Columns["PayPal_username"].DisplayIndex = 6;
            }
            else if (PickPlayertype.SelectedIndex == 2)
            {
                BindingList<FreeToPlay_players> free_users = PlayerManager.GetItemsFromList<FreeToPlay_players>();
                ResigtrationPanel.Controls.Add(new FreeToPlay_registration(free_users));
                dataGridView1.DataSource = free_users;

                dataGridView1.Columns["name"].DisplayIndex = 0;
                dataGridView1.Columns["familyname"].DisplayIndex = 1;
                dataGridView1.Columns["age"].DisplayIndex = 2;
                dataGridView1.Columns["coins"].DisplayIndex = 3;
                dataGridView1.Columns["GamesPlayed"].DisplayIndex = 4;

            }
        }


        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Player deletefromlist = (Player)dataGridView1.Rows[e.Row.Index].DataBoundItem;
            PlayerManager.RemovePerson(deletefromlist);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "password")
            {
                if (e.Value != null)
                {
                    string password = e.Value.ToString();
                    e.Value = new string('*', password.Length);
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "creditcard")
            {
                if (e.Value != null)
                {
                    string creditcard = e.Value.ToString();
                    e.Value = new string('*', creditcard.Length);
                    e.FormattingApplied = true;
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "PayPal_ID")
            {
                if (e.Value != null)
                {
                    string PayPal_ID = e.Value.ToString();
                    e.Value = new string('*', PayPal_ID.Length);
                    e.FormattingApplied = true;
                }
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayerManager.saveTofile();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            soundManager.PlaySound("butten.wav");
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Player selectedPlayer = (Player)dataGridView1.SelectedRows[0].DataBoundItem;
                tetris togame = new tetris();
                if (selectedPlayer is FreeToPlay_players freePlayer)
                {
                    if (freePlayer.CanPlayMoreGames())
                    {
                        freePlayer.PlayGame();

                        
                        togame.SelectedPlayer = selectedPlayer;
                        togame.Show();
                        this.Hide();
                    }
                    else
                    {
                       MessageBox.Show($"{freePlayer.name} doesn't have enough coins to play BUY NOW!");
                    }
                }
                else
                {

                    togame.SelectedPlayer = selectedPlayer;
                    togame.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Please select a player before starting the game.");
            }

        }

        private void View_Click(object sender, EventArgs e)
        {
            soundManager.PlaySound("butten.wav");
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Player selectedPlayer = (Player)dataGridView1.SelectedRows[0].DataBoundItem;

                PlayerPictureForm pictureForm = new PlayerPictureForm();
                pictureForm.SetPlayerPicture(selectedPlayer);
                ResigtrationPanel.Controls.Clear();
                ResigtrationPanel.Controls.Add(pictureForm);
            }
            else
            {
                MessageBox.Show("Please select a player to view.");
            }
        }
        
    }
}
