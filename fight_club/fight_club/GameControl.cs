﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class GameControl
    {
        public AbstractPlayer player1;
        public AbstractPlayer player2;


        public GameControl()
        {
            player1 = new Player(2 , "Jack" , 3 , 3 , 2);
            player2 = new Player(2, "Ted", 2, 2, 4); //new NPC();  // плохо работает бот(бьет только по голове)
        }

        public string[] EndTurn(BodyPart player1punch , BodyPart player1block , BodyPart player2punch , BodyPart player2block)
        {
            string[] returnedString = {"" , ""};
            string firstturn = "";
            string secondturn = "";
            int d1, d2;
            player1.onBlock += Blocked;
            player2.onBlock += Blocked;
            player1.onWound += Wounded;
            player2.onWound += Wounded;


            player1.SetBlock(player1block);
            player2.SetBlock(player2block);

            d2 = player1.GetHit(player2punch, new FightPapams(player2.Straight, player2.Agility));
            d1 = player2.GetHit(player1punch, new FightPapams(player1.Straight, player1.Agility));

            if (d1 != 0)
            {
                firstturn = player1.Name + " punch " + player2.Name  + " on " + d1;   //как вызывать ревкцию события прямо тут?
            }
            else
            {
                firstturn = player2.Name + " blocked punch of " + player1.Name;       //как вызывать ревкцию события прямо тут?
            }
            if (d2 != 0)
            {
                secondturn = player2.Name + " punch " + player1.Name + " on " + d2;   //как вызывать ревкцию события прямо тут?
            }
            else
            {
                secondturn = player1.Name + " blocked punch " + player2.Name;         //как вызывать ревкцию события прямо тут?
            }
            //firstturn = player1.GetHit(player2punch , new FightPapams(player2.Straight , player2.Agility)).ToString();
            //secondturn = player2.GetHit(player1punch, new FightPapams(player1.Straight, player1.Agility)).ToString();

            returnedString[0] = firstturn;
            returnedString[1] = secondturn;
            return returnedString;
        }



        public string Blocked(object sender , BodyPart e)
        {
            return e.ToString();
        }

        public string Wounded(object sender, BodyPart e)
        {
            return e.ToString();
        }

        public string GameOver(object sender , BodyPart e)
        {
            return (sender as AbstractPlayer).Name + " die ";
        }
    }
}
