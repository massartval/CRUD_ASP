namespace CRUD_ASP.Models
{
    public class Administrator : User
    {
        public int AdministratorId { get; set; }
        public bool IsAdmin { get; set; }
    }
}
