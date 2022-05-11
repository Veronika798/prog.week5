using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutaja tunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja salasona on"admin1234"
            //siis konsoolis kuvame "Tere tulemast"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus voi salasona, proovi uuesti."
            //kasutajal on kolm katset. i < 3

            int i = 0;// i-iteration


            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta salasona");
                string userPassword = Console.ReadLine();


                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                else
                {
                    Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti!");
                    i = i + 1;

                }

                Console.WriteLine("Kena paeva!");


            }
        }
    }
}
