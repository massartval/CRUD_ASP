using CRUD_ASP.Context;
using CRUD_ASP.Models;
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
        public ActionResult Create(IFormCollection formData)
        {
            try
            {
                User newUser = new User();
                /* Bind formData fields to newUser properties */
                //newUser.Email = formData.Email;
                //newUser.Password = formData.Password;

                // Open a connection to the database
                using (var context = new DataContext())
                {
                    // Add data to the users table
                    context.Users.Add(newUser);

                    // Save the changes
                    context.SaveChanges();
                }

                string message = "User created";
                // To display the message on the screen
                // after the record is created successfully
                ViewBag.Message = message;
                // write @Viewbag.Message in the created
                // view at the place where you want to
                // display the message

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // Ajouter un message d'erreur
                string message = "User not created";
                ViewBag.Message = message;
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                User userToUpdate = new User();

                using (DataContext context = new DataContext())
                {
                    userToUpdate = context.Users.Find(id);
                }

                return View(userToUpdate);
            }
            catch 
            {
                // Ajouter un message d'erreur
                string message = "User not found";
                ViewBag.Message = message;

                return View();
            }
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection formData)
        {
            try
            {
                User updatedUser = new User();

                // Open a connection to the database
                using (var context = new DataContext())
                {
                    // Find user by id 
                    updatedUser = context.Users.Find(id);

                    /* Bind formData fields to newUser properties */
                    //updatedUser.Email = formData.Email;
                    //updatedUser.Password = formData.Password;

                    // Apply changes to the users table
                    context.Users.Update(updatedUser);
                    // Save the changes
                    context.SaveChanges();
                }
                string message = "User updated";

                // To display the message on the screen
                // after the record is created successfully
                ViewBag.Message = message;
                // write @Viewbag.Message in the created
                // view at the place where you want to
                // display the message

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // Ajouter un message d'erreur
                string message = "User not updated";
                ViewBag.Message = message;

                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            User userToDelete = new User();
            using (DataContext context = new DataContext())
            {
                userToDelete = context.Users.Find(id);
            }
            return View(userToDelete);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                User deletedUser = new User();

                // Open a connection to the database
                using (var context = new DataContext())
                {
                    // Find user by id 
                    deletedUser = context.Users.Find(id);

                    /* Bind formData fields to newUser properties */
                    //updatedUser.Email = formData.Email;
                    //updatedUser.Password = formData.Password;

                    // Delete user from the users table
                    context.Users.Remove(deletedUser);
                    // Save the changes
                    context.SaveChanges();
                }
                string message = "User deleted";

                // To display the message on the screen
                // after the record is created successfully
                ViewBag.Message = message;
                // write @Viewbag.Message in the created
                // view at the place where you want to
                // display the message

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                // Ajouter un message d'erreur
                string message = "User not deleted";
                ViewBag.Message = message;

                return View();
            }
        }
    }
}
