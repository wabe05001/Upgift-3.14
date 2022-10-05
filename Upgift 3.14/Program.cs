using System;

using System.Globalization;

namespace Uppgift_3._14

{

    class program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Har du gått ut gymnasiet?");

            Console.WriteLine("Svara med Ja eller Nej");

            string rättSvar = Console.ReadLine();




            Console.WriteLine("Hur gammal är du?");

            int ålder = int.Parse(Console.ReadLine());




            if (ålder <= 22 & rättSvar == "Ja")

            {

                Console.WriteLine("Vi vill gärna anställa dig!");

            }

            else

            {

                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");

            }

        }

    }

}