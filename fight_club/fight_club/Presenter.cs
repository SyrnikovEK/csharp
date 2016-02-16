﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class Presenter
    {
        frmGame view = null;
        public GameControl game; // = new GameControl();
        public string GameType = "";

        public Presenter(frmGame view)
        {
            game = new GameControl();
            this.view = view;
            if (game.player2 is NPC)
            {
                GameType = "pve";
            }
            else
            {
                GameType = "pvp";
            }
            view.DrawPlayersInfo(game.player1.Name, game.player1.Hp, game.player1.MaxHp, game.player2.Name, game.player2.Hp, game.player2.MaxHp);
        }

        public void EndTurn(int player1punch , int player1block , int player2punch , int player2block)
        {
            view.DrawTextLog(game.Turn((BodyPart)player1punch, (BodyPart)player1block, (BodyPart)player2punch, (BodyPart)player2block));
            view.DrawPlayersInfo(game.player1.Name , game.player1.Hp , game.player1.MaxHp , game.player2.Name, game.player2.Hp, game.player2.MaxHp);
        }

    }
}