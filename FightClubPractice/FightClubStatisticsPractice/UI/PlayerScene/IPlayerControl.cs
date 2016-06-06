using FightClubPractice.Data;
using FightClubPractice.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatisticsPractice.UI.PlayerScene
{
    public interface IPlayerControl : IUserControl
    {
        void DrawUsersTable(List<PlayerDTO> userList);
    }
}
