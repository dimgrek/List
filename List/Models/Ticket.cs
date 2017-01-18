using SQLite;

namespace List.Models
{
    public class Ticket
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string ProblemName { get; set; }
        public Priority Priority { get; set; }
    }
}