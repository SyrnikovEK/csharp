using FightClubPractice.Data;
using FightClubPractice.Game;
using FightClubPractice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.UI.CombatScene
{
    public class CombatScenePresenter
    {
        #region Fields
        CombatUserControl view = null;
        public GameController game; // = new GameControl();
        public GameType gameType;
        public AbstractPlayer player1;
        AbstractPlayer player2;
        public PlayerRepository repos = new PlayerRepository();
        #endregion

        #region Constructors
        public CombatScenePresenter(CombatUserControl view, AbstractPlayer player1, AbstractPlayer player2)
        {
            if (player2 == null)
            {
                game = new GameController(player1);
                gameType = GameType.PvE;
            }
            else
            {
                game = new GameController(player1, player2);
                gameType = GameType.PvP;
            }
            
            this.view = view;
            DrawPlayersInfo();
        }
        #endregion

        #region Methods
        public void DrawPlayersInfo()
        {
            view.DrawPlayersInfo(game.player1.Name, game.player1.Hp, game.player1.MaxHp, game.player2.Name, game.player2.Hp, game.player2.MaxHp);
        }

        public void EndTurn(int player1punch, int player1block, int player2punch, int player2block)
        {
            view.DrawTextLog(game.Turn((BodyPart)player1punch, (BodyPart)player1block, (BodyPart)player2punch, (BodyPart)player2block));
            DrawPlayersInfo();
        }
        #endregion
    }
}