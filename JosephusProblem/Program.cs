using System;
using System.Collections.Generic;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of people.");
            var numberOfPeople = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter killing interval number. It must be greater than 0.");
            var killingInterval = Convert.ToInt32(Console.ReadLine());
            LastPersonStanding(numberOfPeople, killingInterval);
            Console.ReadLine();
        }

        public static void LastPersonStanding(int numberOfPeople, int killingInterval)
        {
            var circleOfPeople = new List<int>();

            for (var i = 1; i <= numberOfPeople; i++)
            {
                circleOfPeople.Add(i);
            }
 
            do
            {
                int Counter = 1;
                for (var i = 0; i < circleOfPeople.Count; i++)
                {
                    if (Counter == killingInterval)
                    {
                        circleOfPeople.RemoveAt(0);
                        Counter = 1;
                    }
                    else
                    {
                        circleOfPeople.Add(circleOfPeople[0]);
                        circleOfPeople.RemoveAt(0);
                        Counter++;
                        i--;
                    }
                }
            }
            while (circleOfPeople.Count > 1);
            Console.WriteLine($"The last person standing in ({numberOfPeople}, {killingInterval}) is at {circleOfPeople[0]} position");
        }
        }
    }

