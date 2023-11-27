﻿
using CalorieTrackerApp.DAL;
using CalorieTrackerApp.DAL.Interface;
using CalorieTrackerApp.DAL.Repository;
using CalorieTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CalorieTrackerApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ICalorieTrackerInterface _calorieTrackerService;
        public readonly Mock<ICalorieTrackerRepository> calorietrackerservice = new Mock<ICalorieTrackerRepository>();
        private readonly Calorie _Calorie;
        private readonly IEnumerable<Calorie> CalorieList;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _calorieTrackerService = new CalorieTrackerService(calorietrackerservice.Object);
            _output = output;
            _Calorie = new Calorie
            {
                Id = 1,
                Date = DateTime.Now,
                CalorieName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            };
             CalorieList = new List<Calorie>
        {
            new Calorie
            {
               Id = 1,
                Date = DateTime.Now,
                CalorieName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
            new Calorie
            {
                Id = 1,
                Date = DateTime.Now,
                CalorieName = "Exercise",
                IsCompleted = true,
                Notes = "30 minutes of jogging in the park."
            },
        };

        }

        [Fact]
        public async Task<bool> Testfor_Get_Calorie()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                 calorietrackerservice.Setup(repos => repos.GetCalories()).Returns(CalorieList);
                var result =  _calorieTrackerService.GetCalories();
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Get_Calorie_ById()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.GetCalorieByID(_Calorie.Id)).Returns(_Calorie);
                var result = _calorieTrackerService.GetCalorieByID(_Calorie.Id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Update_Calorie()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.UpdateCalorie(_Calorie)).Returns(true);
                var result=_calorieTrackerService.UpdateCalorie(_Calorie);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Delete_Calorie()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                calorietrackerservice.Setup(repos => repos.DeleteCalorie(_Calorie.Id)).Returns(1);
                var result=_calorieTrackerService.DeleteCalorie(_Calorie.Id);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}