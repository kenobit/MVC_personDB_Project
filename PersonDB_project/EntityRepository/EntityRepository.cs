using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonDB_project;
using PersonDB_project.Models;

namespace EntityRepository
{
    class EntityRepository : IRepository<User>
    {
        EntityUserContext db = new EntityUserContext();

        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            db.Users.Remove(GetById(id));
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(User item)
        {
            db.Entry<User>(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
