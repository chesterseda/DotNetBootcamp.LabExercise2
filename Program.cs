using System;

namespace CSharp.LabExercise2
{
    internal class Program
    {
        static void Number1()
        {
            int[] numberList = new int[5];
            int i = 0;

            while (i < numberList.Length)
            {
                Console.Write("Enter number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                bool numberExist = false;

                if (input < 10 || input > 100)
                {
                    Console.Write("number must be between 10 and 100");
                }

                else
                {

                    foreach (int component in numberList)
                    {
                        if (component == input)
                        {
                            numberExist = true;

                            foreach (int item in numberList)
                            {
                                if (item > 0)
                                {
                                    Console.Write("{0}  ", item);
                                }
                            }
                            Console.WriteLine("");
                            Console.Write("{0} has already been entered", input); 
                            i++;
                        }
                    }

                    if (numberExist == false)
                    {
                        numberList[i] = input;
                        i++;

                        foreach (int item in numberList)
                        {
                            if (item > 0)
                            {
                                Console.Write("{0}  ", item);
                            }
                        }   
                    }
                }
                Console.WriteLine("\n");
            }
        }

        class Lasagna
        {
            int expectedMinutes;
            int remainingMinutes;
            int preparationTime;
            int elapsedTime;
            public void ExpectedMinutesInOven()
            {
                expectedMinutes = 40;
                Console.WriteLine("Expected time in oven is {0} minutes. \n", expectedMinutes);
            }

            public void RemainingMinutesInOven(int timeInOven)
            {
                remainingMinutes = expectedMinutes - timeInOven;
                Console.WriteLine("Remaining time in oven is {0} minutes. \n", remainingMinutes);
            }

            public void PreparationTimeInMinutes(int layers)
            {
                preparationTime = layers * 2;
                Console.WriteLine("Spent {0} minutes preparing the lasagna. \n", preparationTime);
            }

            public void ElapsedTimeInMinutes(int layers, int timeInOven)
            {
                preparationTime = layers * 2;
                elapsedTime = preparationTime + timeInOven;
                Console.WriteLine("Elapsed time cooking the lasagna is {0} minutes. \n", elapsedTime);
            }

        }

        static void Number2()
        {
            var Lasagna = new Lasagna();

            Lasagna.ExpectedMinutesInOven();

            Console.Write("Enter actual minutes the lasagna has been in the oven : ");
            int actualMinutesInOven = Convert.ToInt32(Console.ReadLine());
            Lasagna.RemainingMinutesInOven(actualMinutesInOven);

            Console.Write("How many layers did you add to the lasagna? ");
            int layersOfLasagna = Convert.ToInt32(Console.ReadLine());
            Lasagna.PreparationTimeInMinutes(layersOfLasagna);

            Lasagna.ElapsedTimeInMinutes(layersOfLasagna, actualMinutesInOven);
        }

            

        static void Main(string[] args)
        {
            Number1();
            Number2();
        }
    }
}
