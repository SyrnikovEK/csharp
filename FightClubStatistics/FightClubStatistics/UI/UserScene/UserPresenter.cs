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
            usersRepository = new UserRepository(new MyContext());
            //usersList = usersRepository.GetAll().ToList();

            usersList = new List<User>();
            //User firstUser = new User { Login = "User4", EMail = "User4@mail.ru", CreationDate = DateTime.Now, IsEmailValid = true, Password = "987654", PlayerData = new Player { Name = "player4" , Exp = 400} };
            //usersRepository.Add(firstUser);
            //usersRepository.Save();

            usersList = usersRepository.GetAll().ToList();

            view.DrawUsersTable(usersList);
        }

        public void EditUser(int id)
        {
            (view as UserUserControl).SwitchScene(Scene.EditUserScene, usersRepository.Get(id));
        }

        public void DeleteUser(int id)
        {
            usersRepository.Delete(id);
            usersRepository.Save();
            usersList = usersRepository.GetAll().ToList();
            view.DrawUsersTable(usersList);
        }

        public void AddUser()
        {
            (view as UserUserControl).SwitchScene(Scene.EditUserScene);
        }

        public void AddUser(User newUser)
        {
            usersRepository.Add(newUser);
            usersRepository.Save();
            usersList = usersRepository.GetAll().ToList();
            view.DrawUsersTable(usersList);
        }
    }
}
