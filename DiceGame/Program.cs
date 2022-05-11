using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mangus osaleb kaks mangijat - arvuti (cpu) ja kasutaja (user)
            //molemad mangijat viskavat taringuid
            //programm kontrollib, kumb mangija viskas rohkem
            //mangija kes viskab rohkem, see ongi voitja
            //*taringuid visatakse 3 korda
            //programm kuulutab voitjat

            for (int i = 0; i < 3; i++)
            {
                while (i < 3)
                {

                    Random rnd = new Random();

                    //arvuti vise
                    int cpuRandom = rnd.Next(1, 7);
                    //kasutaja viskab
                    int userRandom = rnd.Next(1, 7);

                    int cpuScore = 0;
                    int userScore = 0;

                    Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                    if (cpuRandom < userRandom)
                    {
                        Console.WriteLine("Kasutaja on mangu voitnud. Palju onne!");
                        userScore = userScore + 1;
                    }


                    else if (cpuRandom > userRandom)
                    {
                        Console.WriteLine("Arvuti on mangu voitja!");
                        cpuScore = cpuScore + 1;

                    }

                    else
                    {
                        Console.WriteLine("Viik!");
                        cpuScore = cpuScore + 1;
                        userScore = userScore + 1;
                    }

                    break;



                }

            }
        }

    }   }

