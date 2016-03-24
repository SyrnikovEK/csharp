using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FightClubStatistics
{
    public abstract class AbstractRepository
    {
        protected IContext context;
        public AbstractRepository()
        {
            context = new MyContext();
        }
        public AbstractRepository(IContext context)
        {
            this.context = context;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
