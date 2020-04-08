using System;

// 繰り返し文for, while, do~while をそれぞれ利用し、* を5つ表示する
namespace Prob302
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = new string[5];
            string star = "* ";

            // for文
            for(int i = 0; i < n.Length; i++)
            {
                n[i] = star;
                Console.Write(n[i]);
            }
            Console.WriteLine();

            // while文
            int j = 0;
            while( j < n.Length )
            {
                n[j] = star;
                Console.Write(n[j]);
                j ++;
            }
            Console.WriteLine();

            // do~while文
            int w = 0;
            do
            {
                n[w] = star;
                Console.Write(n[w]);
                w++;
            }
            while(w < n.Length);
            Console.WriteLine();
        }
    }
}
