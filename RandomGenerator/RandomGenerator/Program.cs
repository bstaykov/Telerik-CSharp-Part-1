namespace RandomGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RandomGenerator.GetRandomString(1));
            Console.WriteLine(RandomGenerator.GetRandomString(1));
            Console.WriteLine(RandomGenerator.GetRandomString(1));
            Console.WriteLine(RandomGenerator.GetRandomString(1));
            Console.WriteLine(RandomGenerator.GetRandomString(1));
            Console.WriteLine(RandomGenerator.GeneratRandomNumber(0, 2)); // 0 or 1
            Console.WriteLine(RandomGenerator.GeneratRandomNumber(50, 100));
            Console.WriteLine(RandomGenerator.GenerateRandomDouble(50, 100, 3));
            Console.WriteLine(RandomGenerator.GenerateRandomDouble(0, 1, 2));
            Console.WriteLine(RandomGenerator.GenerateRandomWord(0, 2));
            Console.WriteLine(RandomGenerator.GenerateRandomDateTime(DateTime.Now, DateTime.Now.AddYears(1)));
            var startDate = DateTime.Now;
            var endDate = startDate.AddSeconds(1);
            Console.WriteLine("Start date: " + startDate.ToString("dddd dd MMMM hh:mm:ss.fff", CultureInfo.InvariantCulture));
            Console.WriteLine("End date: " + endDate.ToString("dddd dd MMMM hh:mm:ss.fff", CultureInfo.InvariantCulture));
            Console.WriteLine(RandomGenerator.RandomDateMillisecondsImplementation(startDate, endDate).ToString("dddd dd MMMM hh:mm:ss.fff", CultureInfo.InvariantCulture));
        }
    }
}
