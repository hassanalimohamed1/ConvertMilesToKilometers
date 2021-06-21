using System;

namespace ConvertMilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of miles: ");
            int miles = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{miles} miles in kilometres is {Change(miles)}.");
        }
        private static double Change(int miles) {
            const double kilometre = 1.60934;
            double convert = kilometre * Convert.ToDouble(miles);
            return convert;
        }
    }
}
