namespace CRUD_ASP.Models
{
    public class Teacher : User
    {
        public int TeacherId { get; set; }
        public bool IsTeacher { get; set; }
        public bool IsAvailable { get; set; }

        public int HeadTeacherId { get; set; }
    }
}
