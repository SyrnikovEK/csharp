using FightClubPractice.Data;
using FightClubPractice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Game
{
    public class GameController
    {
        #region Fields
        public AbstractPlayer player1;
        public AbstractPlayer player2;
        public CombatLog combatLog = new CombatLog();
        PlayerRepository repos = new PlayerRepository();
        CombatLogRepository combatLogRep = new CombatLogRepository();

        string Blockstring = "";
        string PunchString = "";
        #endregion

        #region Events
        #endregion

        #region Constructors
        public GameController(AbstractPlayer player1)
        {
            this.player1 = new Player(player1.Name, player1.Straight, player1.Agility, player1.Stamina, player1.Exp);
            (this.player1 as Player).PlayerId = (player1 as Player).PlayerId;
            this.player2 = new NPC(player1.Straight + player1.Agility + player1.Stamina);  // special Bot

            combatLog.PlayerId = (player1 as Player).PlayerId;
            //combatLog.SecondPlayer = (Player)player2;
            combatLog.GameType = GameType.PvE;
        }
        public GameController(AbstractPlayer player1, AbstractPlayer player2)
        {
            this.player1 = new Player(player1.Name, player1.Straight, player1.Agility, player1.Stamina, player1.Exp);
            (this.player1 as Player).PlayerId = (player1 as Player).PlayerId;
            this.player2 = new Player(player2.Name, player2.Straight, player2.Agility, player2.Stamina, player2.Exp);
            (this.player2 as Player).PlayerId = (player2 as Player).PlayerId;

            combatLog.PlayerId = (player1 as Player).PlayerId;
            //combatLog.SecondPlayer = (Player)player2;
            combatLog.GameType = GameType.PvP;
        }
        #endregion

        #region Methods
        public HitLog Turn(BodyPart player1punch, BodyPart player1block, BodyPart player2punch, BodyPart player2block)
        {
            HitLog log = new HitLog();

            // round preparation
            player1.SetBlock(player1block);
            player2.SetBlock(player2block);

            if (player2 is NPC)
            {
                player2punch = (BodyPart)(new Random().Next(5));
            }

            // Бьет первый игрок
            log.FirstPalyerHitValue = player2.GetHit(player1punch, new FightPapams(player1.Straight, player1.Agility));
            log.FirstPalyerPart = player1punch;
            log.FirstPalyerResult = log.FirstPalyerHitValue != 0 ? TurnResult.Wound : TurnResult.Miss;

            // Бьет второй игрок
            log.SecondPlayerHitValue = player1.GetHit(player2punch, new FightPapams(player2.Straight, player2.Agility));
            log.SecondPlayerPart = player2punch;
            log.SecondPlayerResult = log.SecondPlayerHitValue != 0 ? TurnResult.Wound : TurnResult.Miss;

            log.FirstPlayerCurrentHp = player1.Hp;
            log.SecondPlayerCurrentHp = player2.Hp;

            combatLog.CombatHitLogs.Add(log);


            // Проверка смерти игрока и награда победителя
            if ((player1.Hp <= 0) && (player2.Hp > 0))  // player2 win
            {
                if (!(player2 is NPC))
                {
                    int oldExp = player2.Exp;
                    player2.AddExp((int)(player1.MaxHp * ((double)(player1.Straight + player1.Stamina + player1.Agility) / (double)(player2.Straight + player2.Stamina + player2.Agility))));
                    combatLog.CombatTime = DateTime.Now;
                    combatLog.Exp = 0;
                    repos.GetAll().Where(x => x.PlayerDTOId == (player2 as Player).PlayerId).First().Exp = player2.Exp;
                    repos.Save();
                    
                    combatLogRep.Add(combatLog);
                    //repos.Update((Player)player2);
                    // need save
                }
                combatLog.Result = GameResult.Loss;
            }
            if ((player2.Hp <= 0) && (player1.Hp > 0))  // player1 win
            {
                int oldExp = player1.Exp;
                player1.AddExp((int)(player2.MaxHp * ((double)(player2.Straight + player2.Stamina + player2.Agility) / (double)(player1.Straight + player1.Stamina + player1.Agility))));
                combatLog.CombatTime = DateTime.Now;
                combatLog.Result = GameResult.Win;
                combatLog.Exp = player1.Exp - oldExp;
                PlayerDTO pl = repos.GetAll().Where(x => x.PlayerDTOId == (player1 as Player).PlayerId).First();
                pl.Exp = player1.Exp;
                repos.Save();

                combatLogRep.Add(combatLog);
                //repos.Update((Player)player1);
                // need save
            }
            if ((player1.Hp <= 0) && (player2.Hp <= 0))  // draw
            {
                combatLog.CombatTime = DateTime.Now;
                combatLog.Result = GameResult.Draw;
                combatLog.Exp = 0;

                combatLogRep.Add(combatLog);
                // need save
            }

            log.CombatLogId = combatLog.CombatLogId;
            HitLogRepository hitLogRep = new HitLogRepository();
            hitLogRep.Add(log);
            return log;
        }

        public void BlockHandler(object sender, BodyPart e)
        {
            Blockstring = e.ToString();
        }

        public void WoundHandler(object sender, BodyPart e)
        {
            PunchString = e.ToString();
        }
        #endregion
    }
}
