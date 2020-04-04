using System;

//入力された数値の数だけ＊を生成するプログラム 3パターン
namespace EP301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値の数だけ*を生成します");
            Console.Write("数値を入力して下さい : ");
            int n = int.Parse(Console.ReadLine());

            // for文
            // for( int i = 0; i < n; i++)
            // {
            //     Console.Write("* ");
            // }

            // while文
            // int i = 0;
            // while(i < n)
            // {
            //     Console.Write("* ");
            //     i++;
            // }

            // do~while文
            if(0 < n)
            {
                int i = 0;
                do
                {
                    Console.Write("* ");
                    i++;
                }
                while(i < n);
            }

            Console.WriteLine();  //生成したあと段落作成
            Console.WriteLine("{0}個生成しました", n);
        }
    }
}
