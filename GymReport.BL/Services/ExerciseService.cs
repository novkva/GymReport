using GymReport.BL.Interfaces;
using GymReport.Common.Entities;
using GymReport.DAL.Interfaces;
using GymReport.DAL.Repositories;

namespace GymReport.BL.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;
        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public int AddExcercise(string name, string? description = default)
        {
            var exercise = new Exercise { Name = name, Description = "desc" };
            var result = _exerciseRepository.AddExercise(exercise);
            return result.Id;
        }

        public void Delete(int id)
        {
            var ex = _exerciseRepository.GetById(id);
            if (ex == null)
            {
                return;
            }
            _exerciseRepository.Delete(ex);
        }

        public async Task<List<Exercise>> GetAllExcercises()
        {
            return await _exerciseRepository.GetAllExercises();
        }

        public Exercise GetById(int id)
        {
            return _exerciseRepository.GetById(id);
        }
    }
}
