using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics.UI.UserScene
{
    class UserPresenter
    {
        private IUserUserControl view = null;
        private List<User> usersList = null;
        private IRepository<User> usersRepository = null;

        public UserPresenter(IUserUserControl ctrl)
        {
            view = ctrl;
            usersRepository = new UserRepository();
            //usersList = usersRepository.GetAll().ToList();

            usersList = new List<User>();
            User firstUser = new User { Login = "User1", EMail = "User1@mail.ru", CreationDate = DateTime.Now, IsEmailValid = true, Password = "123456", PlayerData = new Player() };

            usersList.Add(firstUser);

            view.DrawUsersTable(usersList);
        }
    }
}
