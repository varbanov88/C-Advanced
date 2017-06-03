using System;
using System.Linq;

namespace ParkingSystem
{
    public class ParkingSystem
    {
        public static void Main()
        {
            //judge result: 80/100
            var dimensions = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            int[][] parking = new int[dimensions[0]][];

            for (int i = 0; i < parking.Length; i++)
            {
                parking[i] = new int[dimensions[1]];
            }

            var car = Console.ReadLine();

            while (car != "stop")
            {
                var carData = car.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();
                var entryRow = carData[0];
                var spotRow = carData[1];
                var spotCol = carData[2];
                var isParked = false;

                for (int col = 1; col < parking[spotRow].Length; col++)
                {
                    if (parking[spotRow][col] == 0 && col == spotCol)
                    {
                        parking[spotRow][col] = 1;
                        var distance = col + 1 + Math.Abs(entryRow - spotRow);
                        Console.WriteLine(distance);
                        isParked = true;
                        break;
                    }

                }

                if (!isParked)
                {
                    bool leftAvailable = false;
                    bool rightAvailable = false;
                    var leftDistance = 0;
                    var rightDistance = 0;

                    for (int col = spotCol - 1; col > 0; col--)
                    {
                        if (parking[spotRow][col] == 0)
                        {
                            leftDistance++;
                            leftAvailable = true;
                            break;
                        }
                        leftDistance++;
                    }

                    for (int col = spotCol + 1; col < parking[spotRow].Length; col++)
                    {
                        if (parking[spotRow][col] == 0)
                        {
                            rightDistance++;
                            rightAvailable = true;
                            break;
                        }
                        rightDistance++;
                    }

                    if (!leftAvailable && !rightAvailable)
                    {
                        Console.WriteLine($"Row {spotRow} full");
                    }

                    else
                    {
                        if (leftAvailable && rightAvailable)
                        {
                            if (leftDistance <= rightDistance)
                            {
                                var distance = (spotCol - leftDistance + 1) + Math.Abs(entryRow - spotRow);
                                parking[spotRow][spotCol - leftDistance] = 1;
                                Console.WriteLine(distance);
                            }

                            else
                            {
                                var distance = spotCol + rightDistance + 1 + Math.Abs(entryRow - spotRow);
                                parking[spotRow][spotCol + rightDistance] = 1;
                                Console.WriteLine(distance);
                            }
                        }

                        else if (leftAvailable)
                        {
                            var distance = (spotCol - leftDistance + 1) + Math.Abs(entryRow - spotRow);
                            parking[spotRow][spotCol - leftDistance] = 1;
                            Console.WriteLine(distance);
                        }

                        else
                        {
                            var distance = spotCol + rightDistance + 1 + Math.Abs(entryRow - spotRow);
                            parking[spotRow][spotCol + rightDistance] = 1;
                            Console.WriteLine(distance);
                        }
                    }
                }

                car = Console.ReadLine();
            }
        }
    }
}
