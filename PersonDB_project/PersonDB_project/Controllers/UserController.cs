using PersonDB_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonDB_project.Controllers
{
    public class UserController : Controller
    {
        IRepository<User> repository = new DBFactory().GetInstance("Ado");

        //repo = factory.GetInstance("Entity");

        // GET: User
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // GET: User/Create
        [HttpPost]
        public ActionResult Create(Models.User user)
        {
            repository.Create(user);
            repository.Save();
            return RedirectToAction("Index");
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            User user = repository.GetById(id);
            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(User item)
        {
            try
            {
                
                                
                repository.Update(item);
                repository.Save();

                return RedirectToAction("Index");
            }
            catch
            {
               return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            User user = repository.GetById(id);

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.Delete(id);
                repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
