using GymReport.BL.Interfaces;
using GymReport.Common.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GymReport.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }
        /// <summary>
        /// Add new exercise
        /// </summary>
        /// <returns>Id of added exercise</returns>
        [HttpPost]
        public ActionResult<int> Add(string name)
        {
            return _exerciseService.AddExcercise(name);
        }

        /// <summary>
        /// Get all exercises
        /// </summary>
        /// <returns>List of exercises</returns>
        [HttpGet]
        public async Task<ActionResult<List<Exercise>>> GetAll()
        {
            return await _exerciseService.GetAllExcercises();
        }

        /// <summary>
        /// Delete exercise
        /// </summary>
        /// <param name="id">Id of exercise</param>
        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            _exerciseService.Delete(id);
        }

        /// <summary>
        /// Get one exercise
        /// </summary>
        /// <param name="id">Id of exercise</param>
        /// <returns>Exercise</returns>
        [HttpGet("{id}")]
        public Exercise GetById([FromRoute] int id)
        {
            return _exerciseService.GetById(id);
        }

        ///// <summary>
        ///// Изменить упражнение
        ///// </summary>
        //public void Update()
        //{

        //}
    }
}
