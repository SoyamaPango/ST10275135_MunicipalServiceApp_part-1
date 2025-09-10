using MunicipalServicesApp.Models;
using System.Collections.Generic;

public static class UserStore
{
    public static List<User> Users = new List<User>();
    public static User CurrentUser { get; set; } // store logged-in user

    static UserStore()
    {
        // Default demo accounts
        Users.Add(new User { Username = "resident1", Password = "1234", Role = "Resident" });
        Users.Add(new User { Username = "employee1", Password = "admin", Role = "Employee" });
    }
}
