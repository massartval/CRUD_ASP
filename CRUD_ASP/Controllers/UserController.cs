using CRUD_ASP.Context;
using CRUD_ASP.Models;
using CRUD_ASP.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ASP.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            List<User> users = new List<User>();
            using (DataContext context = new DataContext())
            {
                users = context.Users.ToList();
            }
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            User user = new User();
            using (DataContext context = new DataContext())
            {
                user = context.Users.Find(id);
            }
            return View(user);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserForm form)
        {
            if (ModelState.IsValid)
            {
                User u = new User()
                {
                    Name = form.Name
                    
                };

                using (DataContext context = new DataContext())
                {
                    context.Users.Add(u);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(form);
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // Ajouter un message d'erreur
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
