using System;

// EP409(ビンゴ)におけるArrayクラスのメソッドを利用したプログラム
namespace EP503
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bingo bingo = new Bingo();
            while(true)
            {
                try
                {
                        Console.Write("ビンゴの作成サイズを入力 : ");
                        int size = int.Parse(Console.ReadLine());
                        if(size > 0)
                        {
                            Bingo bingo = new Bingo(size);
                            Console.WriteLine();
                            // bingo.Init(size);
                            bingo.Show();
                            break;
                        }
                }
                catch(FormatException)
                {
                    Console.WriteLine("正数を入力してください");
                }
            }
        }
    }
}
