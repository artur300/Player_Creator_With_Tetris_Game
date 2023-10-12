using System.ComponentModel;
using Tetris_Game.classes;

namespace Tetris_Game.management
{
    public class PlayerManager
    {
        private static BindingList<Player> players;

        static PlayerManager()
        {
            players = file_management.LoadPlayersFromFile();
        }

        public static BindingList<Player> getitem()
        {
            return players;
        }

        public static void RemovePerson(Player Item)
        {
            players.Remove(Item);
        }

        public static void AddPerson(Player Item)
        {
            players.Add(Item);
        }


        public static BindingList<T> GetItemsFromList<T>() where T : Player
        {
            BindingList<T> RequestedItem = new BindingList<T>();
            foreach (var players in players)
            {
                if (players is T)
                {
                    RequestedItem.Add(players as T);
                }
            }

            return RequestedItem;
        }

        public static void saveTofile()
        {
            file_management.SavePlayersToFile(players);
        }
    }
}
