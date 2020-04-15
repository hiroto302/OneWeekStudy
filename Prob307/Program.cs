using System;

// forの二重ループを用いて */ を交互に表示するプログラム
namespace Prob307
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 8; i > 0; i--)
            {
                for(int j = 4; j > 0; j--)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write("*/");
                    }
                    else
                    {
                        Console.Write("/*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
