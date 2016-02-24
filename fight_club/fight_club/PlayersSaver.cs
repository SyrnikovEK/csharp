using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace fight_club
{
    public static class PlayersSaver
    {
        private static string path = "Players.dat";
        
        public static List<Player> Load()
        {
            List<Player> newPlayersList = null;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (true) // if File exist
                {
                    newPlayersList = (List<Player>)formatter.Deserialize(stream);
                }
                else
                {
                    newPlayersList = null;
                }
            }
            return newPlayersList;
        }
        public static void Save(List<Player> db)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, db);
            }
        }
    }
}
