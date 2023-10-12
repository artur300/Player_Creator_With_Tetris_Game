using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Tetris_Game.classes;
using System.ComponentModel;
using System.IO;

namespace Tetris_Game.management
{
    public class file_management
    {


        public static void SavePlayersToFile(BindingList<Player> players)
        {
            try
            {
                BinaryFormatter bin = new BinaryFormatter();
                using (FileStream fileStream = new FileStream("players.bin", FileMode.Create))
                {
                    bin.Serialize(fileStream, players);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving players to file: " + ex.Message);
            }
        }

        public static BindingList<Player> LoadPlayersFromFile()
        {
            BindingList<Player> players = new BindingList<Player>();
            try
            {
                BinaryFormatter bin = new BinaryFormatter();
                using (FileStream fileStream = new FileStream("players.bin", FileMode.Open))
                {
                    players = (BindingList<Player>)bin.Deserialize(fileStream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading players from file: " + ex.Message);
            }
            return players;
        }


    }
}
