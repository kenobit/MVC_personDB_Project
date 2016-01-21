using EntityRepo;
using PersonDB_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonDB_project
{
    public class DBFactory
    {
        public IRepository<User> GetInstance(string ORM)
        {
            IRepository<User> repository;

            switch (ORM)
            {
                case "Entity":
                    {
                        repository = new EntityRepository();
                        break;
                    }
                default:
                    {
                        repository = new EntityRepository();
                        break;
                    }
            }


            return repository;
        }

       
    }
}