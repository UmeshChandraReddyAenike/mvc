using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("Enter  the mark");
            score = Convert.ToInt32(Console.ReadLine());
            if (score > 90)
            {
                Console.WriteLine("Excellent");

            }
            else if (score < 90 && score >= 80)
            {
                Console.WriteLine("Very Good");
            }
            else if (score <80 && score >=70)
            {
                Console.WriteLine("Fair");
            }
            else if (score <70 && score >=60)
            {
                Console.WriteLine("not bad");
            }
            else
            {
                Console.WriteLine("bad");
            }

            Console.ReadKey();
        }
    }
}
