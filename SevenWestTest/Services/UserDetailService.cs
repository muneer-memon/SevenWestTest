using Newtonsoft.Json;
using SevenWestTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SevenWestTest.Services
{
    public class UserDetailService : IUserDetailService
    {
        /// <summary>
        /// This method returns user details by reading from a resource file
        /// </summary>
        /// <returns></returns>
        public List<UserDetail> GetUserData()
        {
            List<UserDetail> users = null;
            try
            {
                // fetching data may change
                // we can call any rest service or mock the data, all it needs is json
                // if invalid json is provided, it will log the exception on console

                users = JsonConvert.DeserializeObject<List<UserDetail>>(File.ReadAllText("../../../Resources/mock/example_data.json"));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception while reading the file, StackTrace: {0}", ex.Message);
            }
            return users;
        }

        /// <summary>
        /// This method returns all the users first names (comma separated who are 23)
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public string GetUsers23YearsOld(List<UserDetail> users)
        {
            var userNames = users.Where(x => x.Age == 23).Select(x => x.First).Aggregate((i, j) => i + "," + j);
            return userNames;
        }
        /// <summary>
        /// This method returns numbers of genders per age, displayed from youngest to oldest
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public List<string> GetUserDetailSummary(List<UserDetail> users)
        {
            var groupedUsers = users.OrderBy(x => x.Age).ThenBy(x => x.Gender).GroupBy(x => x.Age).Select(x => $"Age:{x.Key} Female:{x.Count(y => y.Gender == "F")} Male:{x.Count(y => y.Gender == "M")}").ToList();
            return groupedUsers;
        }
    }
}
