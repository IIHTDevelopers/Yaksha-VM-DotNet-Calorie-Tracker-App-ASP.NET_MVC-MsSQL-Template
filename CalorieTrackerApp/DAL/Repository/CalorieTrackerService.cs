using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CalorieTrackerApp.DAL.Repository
{
    public class CalorieTrackerService : ICalorieTrackerInterface
    {
        private ICalorieTrackerRepository _repo;
        public CalorieTrackerService(ICalorieTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteCalorie(int CalorieId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Calorie GetCalorieByID(int CalorieId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Calorie> ICalorieTrackerInterface.GetCalories()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Calorie ICalorieTrackerInterface.InsertCalorie(Calorie Calorie)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool ICalorieTrackerInterface.UpdateCalorie(Calorie Calorie)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}