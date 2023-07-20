using GymReport.Common.Entities;

namespace GymReport.BL.Interfaces
{
    public interface IExerciseService
    {
        int AddExcercise(string name, string? description = default);
        Task<List<Exercise>> GetAllExcercises();
        void Delete(int id);
    }
}
