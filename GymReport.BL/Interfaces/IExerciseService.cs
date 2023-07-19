namespace GymReport.BL.Interfaces
{
    public interface IExerciseService
    {
        int AddExcercise(string name, string? description = default);
    }
}
