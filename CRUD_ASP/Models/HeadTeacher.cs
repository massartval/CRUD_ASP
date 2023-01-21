namespace CRUD_ASP.Models
{
    public class HeadTeacher
    {
        public int HeadTeacherId { get; set; }
        public string EnterpriseName { get; set; }
        public bool IsHeadTeacher { get; set; }
        public int TeacherId { get; set; }
        public int TrainingId { get; set; }
    }
}
