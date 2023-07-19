using Microsoft.AspNetCore.Mvc;

namespace GymReport.Controllers
{
    public class ExerciseController : Controller
    {
        /// <summary>
        /// Добавить новое упражнение
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// Получить все имеющиеся упражнения
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAll()
        {
            return View();
        }
 
        /// <summary>
        /// Удалить упражнение
        /// </summary>
        public void Delete()
        {

        }

        /// <summary>
        /// Изменить упражнение
        /// </summary>
        public void Update()
        {

        }
    }
}
