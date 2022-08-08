using System;
using System.Collections.Generic;

namespace DelegatesHelper
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {DateOfBirthday} {PhoneNumber}";
        }
    }

    public class FNameCompare : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }

    public class LNameCompare : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }

    public class DoBCompare : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.DateOfBirthday.CompareTo(y.DateOfBirthday);
        }
    }

    public class NumberCompare : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.PhoneNumber.CompareTo(y.PhoneNumber);
        }
    }

    public class Delegates
    {
        //1)Create method for list sorting fuction(User{ FirstName,LastN,DateOfBirthday,PhoneNumber})
        //*Generic version
        //2)Create delegate which will allow to set Console.ReadLine()\WriteLine() inside it.
        //3)There is User{FirstName,LastN,DateOfBirthday,PhoneNumber
        //}. Create method to filter users list.
        //*4)Create universal method to filter any collection (generic)
        //5)Create method which will repeat code part (should be as input parameter)
        //while condition(should be as input parameter) is true N times.
    }

    public class FirstTask<T>
    {
        public delegate void sort(T[] list, bool ascending = true);
        private static void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void Sort(T[] list, Func<T, T, int> comparer, bool ascending = true)
        {
            int coef = ascending ? 1 : -1;
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (comparer(list[i], list[j]) == coef)
                    {
                        Swap(ref list[i], ref list[j]);
                    }
                }
            }
        }
    }

    public class SecondTask
    {
        public static void RepeatToDuplication(Action action, Func<bool> condition, int timesToRepeat)
        {
            while(condition())
            {
                action();
            }
        }
        Func<bool> condition = new Func<bool>(() => false);
    }
}
