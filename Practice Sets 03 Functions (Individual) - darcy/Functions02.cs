using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
