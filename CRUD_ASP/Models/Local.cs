namespace CRUD_ASP.Models
{
    public class Local
    {
        public int LocalId { get; set; }
        public int MaxCapacity { get; set; } = 0;
        public int ComputerAvailable { get; set; } = 0;
        public int InteractiveWhiteBoard { get; set; } = 0;
        public int SingleBoard { get; set; } = 0;
        public int Projector { get; set; } = 0; 

    }
}
