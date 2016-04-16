using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics.UI.UserScene
{
    class UserPresenter
    {
        private IUserUserControl view;
        private List<User> usersList;
        private IRepository<User> usersRepository;

        public UserPresenter(IUserUserControl ctrl)
        {
            view = ctrl;
            usersRepository = new UserRepository(new MyContext());
            usersList = new List<User>();
            usersList = usersRepository.GetAll().ToList();

            view.DrawUsersTable(usersList);
        }

        public void TurnEditUserControl(int id)
        {
            view.SwitchScene(Scene.EditUserScene, usersRepository.Get(id));
        }

        public void EditUser(User user)
        {
            usersRepository.Update(user);
            UpdateUsersList();
        }

        public void DeleteUser(int id)
        {
            usersRepository.Delete(id);
            UpdateUsersList();
        }

        public void TurnAddUserControl()
        {
            view.SwitchScene(Scene.EditUserScene);
        }

        public void AddUser(User newUser)
        {
            usersRepository.Add(newUser);
            UpdateUsersList();
        }
        
        private void UpdateUsersList()
        {
            usersList = usersRepository.GetAll().ToList();
            view.DrawUsersTable(usersList);
        }
    }
}
