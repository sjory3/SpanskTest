using System;


namespace SpanskTest
{
    class Program
    {
        static string word = "Hablar";
        static string[] ending = new string[6];

        static bool continuation = true;
        static int slecetion;
        
        static void Main(string[] args)
        {
            Console.Title = "Fremtid";

            ending[0] = "Hablaré";
            ending[1] = "Hablarás";
            ending[2] = "Hablará";
            ending[3] = "Hablaremos";
            ending[4] = "Hablaréis";
            ending[5] = "Hablarán";



            Random rng = new Random();



            while (continuation == true)
            {
                slecetion = rng.Next(0, 6);

                if (slecetion == 0)
                {
                    Console.WriteLine($"Hvad er den 1st per. sing. af {word}");
                    Checker(slecetion);
                }
                else if (slecetion == 1)
                {
                    Console.WriteLine($"Hvad er den 2st per. sing. af {word}");
                    Checker(slecetion);
                }
                else if (slecetion == 2)
                {
                    Console.WriteLine($"Hvad er den 3st per. sing. af {word}");
                    Checker(slecetion);
                }
                else if(slecetion == 3)
                {
                    Console.WriteLine($"Hvad er den 1st per. plur. af {word}");
                    Checker(slecetion);
                }
                else if (slecetion == 4)
                {
                    Console.WriteLine($"Hvad er den 2st per. plur. af {word}");
                    Checker(slecetion);
                }
                else if (slecetion == 5)
                {
                    Console.WriteLine($"Hvad er den 3st per. plur. af {word}");
                    Checker(slecetion);
                }
                else
                {
                    Console.WriteLine("Yo WHAT THE FUCK");
                }
            }
            Console.ReadLine();

        }

        public static void Checker(int slection)
        {
            string userWord = Console.ReadLine();

            if (userWord.ToLower() == ending[slecetion].ToLower())
            {
                Console.WriteLine("--------------------------\n" +
                                  "         Correct\n" +
                                  "--------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------\n" +
                                  "          Wrong\n" +
                                  "--------------------------\n");
            }
        }
    }
}