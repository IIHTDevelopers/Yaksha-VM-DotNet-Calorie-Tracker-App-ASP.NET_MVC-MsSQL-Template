using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CalorieTrackerApp.DAL.Repository
{
    public class CalorieTrackerRepository : ICalorieTrackerRepository
    {
        private CalorieTrackerDbContext _context;
        public CalorieTrackerRepository(CalorieTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Calorie> GetCalories()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Calorie GetCalorieByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Calorie InsertCalorie(Calorie Calorie)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteCalorie(int CalorieID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateCalorie(Calorie Calorie)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
