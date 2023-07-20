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
        /// Добавить новое упражнение
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<int> Add(string name)
        {
            return _exerciseService.AddExcercise(name);
        }

        /// <summary>
        /// Получить все имеющиеся упражнения
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Exercise>>> GetAll()
        {
            return await _exerciseService.GetAllExcercises();
        }

        ///// <summary>
        ///// Удалить упражнение
        ///// </summary>
        //public void Delete()
        //{

        //}

        ///// <summary>
        ///// Изменить упражнение
        ///// </summary>
        //public void Update()
        //{

        //}
    }
}
