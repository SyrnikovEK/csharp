using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_club
{
    public class Presenter
    {
        CombatForm view = null;
        public GameControl game; // = new GameControl();
        public GameType gameType;

        public Presenter(CombatForm view)
        {
            game = new GameControl();
            this.view = view;
            if (game.player2 is NPC)
            {
                gameType = GameType.PvE;
            }
            else
            {
                gameType = GameType.PvP;
            }
            DrawPlayersInfo();
            game.GameOver += GameOverHandler;
        }


        public void DrawPlayersInfo()
        {
            view.DrawPlayersInfo(game.player1.Name, game.player1.Hp, game.player1.MaxHp, game.player2.Name, game.player2.Hp, game.player2.MaxHp);
        }

        public void EndTurn(int player1punch , int player1block , int player2punch , int player2block)
        {
            view.DrawTextLog(game.Turn((BodyPart)player1punch, (BodyPart)player1block, (BodyPart)player2punch, (BodyPart)player2block));
            DrawPlayersInfo();
        }

        public void GameOverHandler(object sender , AbstractPlayer e)
        {
            string[] str = { "", "" };
            str[0] = (sender as AbstractPlayer).Name + " die";
            str[1] = "Game Over";
            view.DrawTextLog(str);
            //game = new GameControl();
        }

    }
}
