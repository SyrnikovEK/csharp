using FightClubStatistics.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class TransactionRepository : AbstractRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository()
        {
            MyContext context = new MyContext();
        }
        
        public override void Update(Transaction item)
        {
            Transaction oldTranasction;
            oldTranasction = context.Transactions.Where(x => x.TransactionId == item.TransactionId).FirstOrDefault();
            oldTranasction.User = new User
            {
                Login = item.User.Login,
                Password = item.User.Password,
                EMail = item.User.EMail,
                IsEmailValid = item.User.IsEmailValid,
                CreationDate = item.User.CreationDate,
                PlayerData = new Player
                {
                    Name = item.User.PlayerData.Name,
                    Exp = item.User.PlayerData.Exp
                }
            };
            oldTranasction.Sum = item.Sum;
            oldTranasction.Date = item.Date;

            context.SaveChanges();
        }
    }
}
