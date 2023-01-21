namespace CRUD_ASP.Models
{
    public class Student : User
    {
        public int StudentId { get; set; }
        public string NationalNumber { get; set; }
        public bool IsStudent { get; set; }
        public int RegistrationRequest { get; set; }
        public int modulAlreadyCompleted { get; set; }
        public bool IsAdmitted { get; set; }

    }
}
