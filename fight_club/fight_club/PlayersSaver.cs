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
        public static string path = "Players.dat";
        
        public static PlayersDB Load()
        {
            PlayersDB newPlayersDB = null;

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                newPlayersDB = (PlayersDB)formatter.Deserialize(stream);
            }
            return newPlayersDB;
        }
        public static void Save(PlayersDB db)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, db);
            }
        }
    }
}
