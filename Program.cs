using System;

namespace fromatob
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int reps = 0;

            string ab = Console.ReadLine();
            string[] abArray = ab.Split(' ');



            // WriteLine(splitWords[0]); This was just a check to see if I was correctly assigning the values
            // WriteLine(splitWords[1]); This was just a check to see if I was correctly assigning the values
            // I removed the above lines in case it might be causing the long run time.

            a = Convert.ToInt32(abArray[0]);

            b = Convert.ToInt32(abArray[1]);

            //WriteLine(a);
            // WriteLine(b);

            while (a > b)
            {
                if (a % 2 != 0)
                {
                    a += 1;
                    reps += 1;
                }

                a /= 2;
                reps += 1;
            }
            if (a < b)
            {
                reps += b - a;
            }

            Console.WriteLine(reps);
        }


    }
}

