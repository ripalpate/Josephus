using System;

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
            var position = LastPersonStanding(numberOfPeople, killingInterval);
            Console.WriteLine($"The last person standing in ({numberOfPeople}, {killingInterval}) is at {position} position");
            Console.ReadLine();
        }
        public static int LastPersonStanding(int numberOfPeople, int killingInterval)
        {
            if (numberOfPeople == 1)
            {
                return 1;
            }
            else {
                // The position of LastPersonStanding is adjusted due to recursive call to (numberOfPeople - 1, killingInterval) 
                // and it considers the original position killingInterval%numberOfpeople +1 as 1
                return (LastPersonStanding(numberOfPeople - 1, killingInterval) + killingInterval - 1) % numberOfPeople + 1;
            }
        }
    }
}
