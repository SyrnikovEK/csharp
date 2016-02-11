using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class GameControl
    {
        AbstractPlayer player1;
        AbstractPlayer player2;

        public GameControl()
        {
            player1 = new Player();
            player2 = new NPC();
        }

        public string[] EndTurn(BodyPart player1punch , BodyPart player1block , BodyPart player2punch , BodyPart player2block)
        {
            string[] returnedString = {"" , ""};
            string firstturn = "";
            string secondturn = "";
            
            player1.SetBlock(player1block);
            player2.SetBlock(player2block);

            firstturn = player1.GetHit(player2punch , new FightPapams(player2.Straight , player2.Agility)).ToString();
            secondturn = player2.GetHit(player1punch, new FightPapams(player1.Straight, player1.Agility)).ToString();

            returnedString[0] = firstturn;
            returnedString[1] = secondturn;
            return returnedString;
        }
    }
}
