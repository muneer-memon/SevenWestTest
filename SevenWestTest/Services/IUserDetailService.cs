using System.Collections.Generic;
using SevenWestTest.Models;

namespace SevenWestTest.Services
{
    public interface IUserDetailService
    {
        List<UserDetail> GetUserData();
        string GetUsers23YearsOld(List<UserDetail> users);
        List<string> GetUserDetailSummary(List<UserDetail> users);
    }
}