using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_questions
{
    internal class PQ2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your  number");
            int sum = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            
            while (num > 0)
            {
                sum +=num%10 ;
                    num /= 10;
            }
            Console.WriteLine($"sum of all digit is : {sum}");
           
        }
    }
}
