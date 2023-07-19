using GymReport.Common.Entities;

namespace GymReport.DAL.Interfaces
{
    public interface IExerciseRepository
    {
        Exercise AddExercise(Exercise exercise);
    }
}
