using FightClubPractice.Data;
using FightClubPractice.Game;
using FightClubPractice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatisticsPractice.UI.PlayerScene
{
    public class PlayerPresenter
    {
        private IPlayerControl view;
        private List<PlayerDTO> usersList;
        private PlayerRepository usersRepository;
        private int showingCount;

        public PlayerPresenter(IPlayerControl ctrl)
        {
            view = ctrl;
            usersRepository = new PlayerRepository();
            usersList = new List<PlayerDTO>();
            usersList = usersRepository.GetAll().ToList();
            showingCount = usersList.Count;

            view.DrawUsersTable(usersList);
        }

        public void TurnEditUserControl(int id)
        {
            view.SwitchScene(Scene.PlayerEditScene, usersRepository.Get(id));
        }

        public void EditUser(PlayerDTO user)
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
            view.SwitchScene(Scene.PlayerEditScene);
        }

        public void AddUser(PlayerDTO newUser)
        {
            usersRepository.Add(newUser);
            UpdateUsersList();
        }

        private void UpdateUsersList()
        {
            usersList = usersRepository.GetAll().ToList();
            view.DrawUsersTable(usersList);
        }

        public void ChangeUsersShowingCount(int count)
        {
            showingCount = count;
            if (showingCount <= usersRepository.GetAll().Count())
            {
                view.DrawUsersTable(usersList.Take(showingCount).ToList());
            }
            else
            {

            }
        }

        public void ShowAllUsers()
        {
            UpdateUsersList();
        }

        public void ShowUsersWithValidEmails()
        {
            //usersList = usersRepository.GetAllWithValidEmail().ToList();
            view.DrawUsersTable(usersList);
        }

        public void ShowUsersWithoutValidEmails()
        {
            //usersList = usersRepository.GetAllWithoutValidEmail().ToList();
            view.DrawUsersTable(usersList);
        }
    }
}
