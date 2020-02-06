using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskCalendar.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskCalendar
{
    public class HomeController : Controller
    {
        // Вывод таблицы заданий на неделю
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        
        // Отметка о выполнении
        public IActionResult ExecuteTask(int taskID, ITaskExecution execution)
        {
            return null;
        }


        // Запрос представления изменения/создания задания
        public IActionResult ChangeTask(ICalendarTask task)
        {
            return View();
        }

        // Сохрание изменения задания
        public IActionResult SaveTask(ICalendarTask task)
        {
            return null;
        }

        // Удаление задания
        public IActionResult DeleteTask(int taskID)
        {
            return null;
        }

    }
}
