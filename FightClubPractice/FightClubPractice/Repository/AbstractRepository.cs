using FightClubPractice.Context;
using FightClubPractice.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubPractice.Repository
{
    public abstract class AbstractRepository<T> : IRepository<T> where T : class
    {
        protected FightClubContext context;
        public AbstractRepository()
        {
            context = new FightClubContext();
        }

        public virtual void Add(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            T element = context.Set<T>().Find(id);
            if (element != null)
            {
                context.Set<T>().Remove(element);
            }
            context.SaveChanges();
        }

        public virtual T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }

        public virtual bool IsExist(string name)
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }

        public virtual void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}