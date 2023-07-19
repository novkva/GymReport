using Microsoft.AspNetCore.Mvc;

namespace GymReport.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingController : ControllerBase
    {

        private readonly ILogger<TrainingController> _logger;

        public TrainingController(ILogger<TrainingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Создаем тренировку
        /// </summary>
        public void AddWorkout()
        {

        }

        /// <summary>
        /// Добавить подход
        /// </summary>
        public void AddSet()
        {

        }
         
    }
}