using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubStatistics
{
    class TransactionRepository : AbstractRepository, IRepository<Transaction>
    {
        public void Add(Transaction item)
        {
            context.Transactions.Add(item);
        }

        public void Delete(int id)
        {
            Transaction transaction = context.Transactions.Find(id);
            if (transaction != null)
            {
                context.Transactions.Remove(transaction);
            }
        }

        public Transaction Get(int id)
        {
            return context.Transactions.Find(id);
        }

        public IEnumerable<Transaction> GetAll()
        {
            return context.Transactions;
        }

        public void Update(Transaction item)
        {
            throw new NotImplementedException();
        }
    }
}
