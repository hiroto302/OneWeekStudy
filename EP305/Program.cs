using System;

// for文の二重ループを用いて九九の表を作成するプログラム
namespace EP305
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int f = 1; f < 10; f++)
            {
                for( int s = 1; s < 10; s++)
                {
                    int answer = f * s;
                    Console.Write("{0} ✖️ {1} = {2, 2:d} ", f, s, answer);  // 2:d 2桁の数値を右揃えで表示する 他にも色々な書式がある
                }
                Console.WriteLine();
            }
        }
    }
}
