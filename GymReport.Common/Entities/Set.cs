namespace GymReport.Common.Entities
{
    public class Set
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Count { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int WorkoutId { get; set; }
    }
}
