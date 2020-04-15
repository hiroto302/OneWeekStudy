using System;
using System.Collections.Generic;
using System.Linq;

// forループを用いて、1~100までの乱数を5個発生させ、その中の最大値、最小値を求めるプログラム
namespace Prob305
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                int n = random.Next(1, 101);
                numbers.Add(n);
            }
            foreach(int i in numbers)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("最大値 : {0}", numbers.Max());
            Console.WriteLine("最小値 : {0}", numbers.Min());
        }
    }
}
