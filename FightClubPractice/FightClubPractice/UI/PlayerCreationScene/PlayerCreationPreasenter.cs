using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.UI.PlayerCreationScene
{
    public class PlayerCreationPresenter
    {
        PlayerCreationUserControl view;
        public PlayerCreationPresenter(PlayerCreationUserControl view)
        {
            this.view = view;
        }
    }
}
