using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A beer time is after 1:00 PM and before 3:00 AM.
                Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00… 59]  and  AM / PM designator) and prints beer time or non-beer time according to the definition above or     invalid  time if the    time cannot be parsed. Note: You may need to learn how to parse dates and times.
                         */

            Console.WriteLine("Insert hour (01-12): ");
            string hour = Console.ReadLine();

            Console.WriteLine("Insert minutes (01-59): ");
            string minutes = Console.ReadLine();

            Console.WriteLine("Insert AM or PM designator: ");
            string designator = Console.ReadLine();

            string time = string.Format("{0}:{1} {2}", hour, minutes, designator);

            DateTime actualTime;
            bool isRealTime = DateTime.TryParse(time, out actualTime);

            if (isRealTime)
            {
                if (actualTime.Hour > 13 || actualTime.Hour < 3) 
                {
                    Console.WriteLine("Beer time.");
                }
                else
                {
                    Console.WriteLine("Non-Beer time.");
                }
            }
            else
            {
                Console.WriteLine("Invalid time.");
            }
        }
    }
}
