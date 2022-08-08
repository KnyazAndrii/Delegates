using DelegatesHelper;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User a = new User
            {
                FirstName = "Andrii",
                LastName = "Zaharuk",
                DateOfBirthday = new DateTime(2003, 09, 08),
                PhoneNumber = 0684650021
            };

            User b = new User
            {
                FirstName = "Oleh",
                LastName = "Melnuk",
                DateOfBirthday = new DateTime(2010, 01, 22),
                PhoneNumber = 0688428193
            };

            User c = new User
            {
                FirstName = "Valerii",
                LastName = "Shevchenko",
                DateOfBirthday = new DateTime(2000, 11, 30),
                PhoneNumber = 0688372894
            };

            User d = new User
            {
                FirstName = "Oksana",
                LastName = "Yavorska",
                DateOfBirthday = new DateTime(2005, 02, 10),
                PhoneNumber = 0684650021
            };

            User[] users = new User[4];
            users[0] = a;
            users[1] = b;
            users[2] = c;
            users[3] = d;

            User[] newUsers = new User[4];
            newUsers = FirstTask<User>.Sort(users, FNameCompare.Compare());
        }
    }
}
