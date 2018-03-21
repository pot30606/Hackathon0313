using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon0NotDivisibleBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("判斷1~100那些數字不會被整除");
            for(int i = 1; i <= 100; i++)
            {
                if(i%15!=0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
