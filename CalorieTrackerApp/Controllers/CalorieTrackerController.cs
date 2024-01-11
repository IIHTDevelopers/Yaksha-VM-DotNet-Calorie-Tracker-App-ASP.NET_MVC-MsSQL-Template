using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.DAL.Repository;
using CalorieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CalorieTrackerApp.Controllers
{
    public class CalorieTrackerController : Controller
    {
        private readonly ICalorieTrackerInterface _Repository;
        public CalorieTrackerController(ICalorieTrackerInterface service)
        {
            _Repository = service;
        }
        public CalorieTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: CalorieTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Calorie Calorie)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Calorie Calorie)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}