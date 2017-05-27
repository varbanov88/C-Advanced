using System;
using System.Collections.Generic;

namespace Lab
{
    public class ParkingLot
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (!input.Equals("END"))
            {
                var data = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (data[0].Equals("IN"))
                {
                    parking.Add(data[1]);
                }

                else
                {
                    parking.Remove(data[1]);
                }

                input = Console.ReadLine();
            }

            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
