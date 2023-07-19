namespace GymReport.Common.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Set> Sets { get; set; }
        public int UserId { get; set; }
    }
}
