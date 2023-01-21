using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ASP.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       

        
        // Ne pas déclarer de constructeur => conflits fichier config.

        //public User( int id, string email, string password) 
        //{
        //    Id = id; 
        //    Email = email;
        //    Password = password;
            
        //}
    }
}
