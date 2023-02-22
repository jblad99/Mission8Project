using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission8_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Project.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext tContext { get; set; }

        public HomeController(TaskContext someName)
        {
            tContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewTask()
        {
            //Includes the separate categories class in the MoviesForm view
            ViewBag.Categories = tContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult NewTask(TaskForm t)
        {
            if (ModelState.IsValid)
            {
                //if valid, saves changes to the database
                tContext.Add(t);
                tContext.SaveChanges();

                return View("Confirmation", t);
            }
            else
            {
                ViewBag.Categories = tContext.Categories.ToList();

                return View();
            }
        }
        public IActionResult Quadrants()
        {
            var tasks = tContext.Responses
                .Include(x => x.Category)
                //.Where(x => x.CreeperStalker == false)
                .OrderBy(x => x.Task)
                .ToList();

            return View(tasks);
        }
        [HttpGet]
        public IActionResult Edit(int taskid)
        {
            ViewBag.Categories = tContext.Categories.ToList();

            var task = tContext.Responses.Single(x => x.TaskId == taskid);

            return View("NewTask", task);
        }
        [HttpPost]
        public IActionResult Edit(TaskForm blah)
        {
            //Using this to update the database
            tContext.Update(blah);
            tContext.SaveChanges();

            return RedirectToAction("Quadrants");
        }
        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            var task = tContext.Responses.Single(x => x.TaskId == taskid);

            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(TaskForm t)
        {
            //Delete a movie from the database
            tContext.Responses.Remove(t);
            tContext.SaveChanges();

            return RedirectToAction("Quadrants");
        }
    }
}
