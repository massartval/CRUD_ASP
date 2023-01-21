namespace CRUD_ASP.Models
{
    public class Employee : User
    {
        public int EmployeeId { get; set; }
        public bool IsEmployee { get; set; }
        public void AcceptRegistration()
        {

        }
    }
}
