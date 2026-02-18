using System;
using System.Threading;

namespace Git_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool counting = true;

            while (counting == true) // new programmer style
            {
                string fizz = "";
                string buzz = "";
                string fizzbuzz = "";

                if (count % 3 == 0)
                {
                    fizz = "Fizz";
                }
                else
                {
                    fizz = "";
                }

                if (count % 5 == 0)
                {
                    buzz = "Buzz";
                }
                else
                {
                    buzz = "";
                }

                if ((count % 3 == 0) && (count % 5 == 0))
                {
                    fizzbuzz = fizz + buzz;
                }
                else
                {
                    fizzbuzz = fizz + buzz; 
                }

                if (fizzbuzz == "")
                {
                    fizzbuzz = "(none)";
                }

                Console.WriteLine(count + "! " + fizzbuzz);

                count = count + 1;
                Thread.Sleep(500);

                if (count > 100)
                {
                    counting = false;
                }
            }
        }
    }
}
