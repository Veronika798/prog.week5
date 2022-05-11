using System;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutaja tunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja salasona on"admin1234"
            //siis konsoolis kuvame "Tere tulemast"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus voi salasona, proovi uuesti."

            //OR || (pipes)
            //true || true--> true
            //false||true -->true
            //true|| false --> true
            //false||false -->false


            Console.WriteLine("Sisesta kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta salasona");
            string userPassword = Console.ReadLine();


            if(userName!= "admin" || userPassword!= "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uueesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            //"admin1" !="admin" || "admin1234" != "admin1234" --> true||false --> kokku on ikkagi true
            //"admin" != "admin" || "admin123" != "admin1234" --> false||true --> kokku on ikkagi true
            //"admin1" !="admin" || "admin123" != "admin1234" --> true||true --> kokku on true
            //"admin" !="admin" || "admin1234" != "admin1234" --> false||false --> kokku on false

        }
    }
}
