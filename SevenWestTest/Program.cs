using SevenWestTest.Services;
using System;
using System.Linq;

namespace SevenWestTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var userDetailService = new UserDetailService();
            var users = userDetailService.GetUserData();
            if (users != null)
            {
                // users full name of id 42
                var user = users.Where(x => x.Id == 42).FirstOrDefault();
                if (user != null)
                {
                    Console.WriteLine($"{user.First} {user.Last}");
                }
                // find users who have age equals to 23
                var userNames = userDetailService.GetUsers23YearsOld(users);
                if (!string.IsNullOrEmpty(userNames))
                {
                    Console.WriteLine(userNames);
                }
                // group by age, gender 
                var groupedUsers = userDetailService.GetUserDetailSummary(users);
                foreach (string item in groupedUsers)
                {
                    Console.WriteLine(item);
                }
            }
        }

        
    }
}
