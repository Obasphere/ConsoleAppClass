using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Service.SaveController;

namespace ConsoleAppClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string samples
            string Joyce = "Joyce First App";
            string joyce = "Joyce(jnr.) First App";
            string joyce2 = "667";


            Console.WriteLine(joyce);
            Console.WriteLine(Joyce);
            Console.WriteLine(joyce2);

            // integer samples
            int A = 7;
            int B = 444;

            Console.WriteLine(A);
            A = 9;

            Console.WriteLine(A);
            Console.WriteLine(A + B);

            if(A > B)
            {
                Console.WriteLine($"A is Awesome, cos it equals {A}");
            }
            else
            {
                Console.WriteLine($"A is Awesome, cos it equals {B}");
            }

            if(A > B)
            {
                Console.WriteLine("A is Awesome, cos it equals {A}");
            }
            else
            {
                Console.WriteLine("A is Awesome, cos it equals {B}");
            }

            //A > B ? "B" : "A";

            if (A > B)
            {
                Console.WriteLine($"A is Awesome, cos it equals {A}");
            }
            else if (A < B)
            {
                Console.WriteLine($"A is Awesome, cos it equals {B}");
            }

            if (A > B)
            {
                Console.WriteLine($"A is Awesome, cos it equals {A}");
            }
            if (A < B)
            {
                Console.WriteLine($"A is Awesome, cos it equals {B}");
            }

            //concatenate
            Console.WriteLine($"{A} + {B}");
            Console.WriteLine(A + " is a good number for" + " " + Joyce);
            Console.WriteLine($"{A} is a good number for {Joyce}");

            //Console.WriteLine("My first App");


            //Console.WriteLine("My second App");

            //Console.WriteLine("My third App");
            //Console.WriteLine(2 + 45);
            //Console.WriteLine(3 < 2);
            //Console.WriteLine(3  > 2);
            //Console.WriteLine(3 < 2);
            //Console.WriteLine(3 == 2);
            //Console.WriteLine(3 <= 2);

            // Salutation based on current time (hour) in UTC
            string Salutation;
            if (DateTime.UtcNow.Hour >= 0 && DateTime.UtcNow.Hour < 11)
            {
                Salutation = "Bonjour";
            }
            else if (DateTime.UtcNow.Hour >= 11 && DateTime.UtcNow.Hour < 15)
            {
                Salutation = "Bonsoir";
            }
            else if (DateTime.UtcNow.Hour >= 15 && DateTime.UtcNow.Hour < 20)
            {
                Salutation = "Salut";
            }
            else
            {
                Salutation = "Allô";
            }
            Console.WriteLine(Salutation);
        }
    }
}