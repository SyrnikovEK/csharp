using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class UserRepository : AbstractRepository, IRepository<User>
    {
        public void Add(User item)
        {
            context.Users.Add(item);
        }

        public void Delete(int id)
        {
            User user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
            }
        }

        public User Get(int id)
        {
            return context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return context.Users;
        }

        public void Update(User item)
        {
            //context.
        }

        public IEnumerable<User> FindRegisteredUsersByDate(DateTime date)
        {
            return GetAll().Where(user => user.CreationDate == date).ToList();
        }

        public IEnumerable<User> FindUsersWithValidEMail()
        {
            return GetAll().Where(user => user.IsEmailValid).ToList();
        }
    }
}
