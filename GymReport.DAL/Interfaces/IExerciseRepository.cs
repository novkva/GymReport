using GymReport.Common.Entities;

namespace GymReport.DAL.Interfaces
{
    public interface IExerciseRepository
    {
        Exercise AddExercise(Exercise exercise);
        Task<List<Exercise>> GetAllExercises();
        void Delete(Exercise exercise);
        Exercise GetById(int id);
    }
}
