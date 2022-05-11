using System;

namespace moreloops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutaja tunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja salasona on"admin1234"
            //siis konsoolis kuvame "Tere tulemast"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus voi salasona, proovi uuesti."



            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta salasona");
            string userPassword = Console.ReadLine();

            //AND &&
            //"admin" and "admin1234"--> true
            //"admin1" and "admin1234" --> false
            //"admin" and "admin1224" --> false
            //"admin1" and "admminn123" --> false

            if (userName == "admin" && userPassword =="admin1234") 
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti!");
            }


        }
    }
}
