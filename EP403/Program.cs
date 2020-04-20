using System;

// 入力された数nの縦n*横nのビンゴカード作るBingoクラスを作成。ビンゴカードを作成するメソッド、その内容を表示するメソッドを実装し実行すプログラム
// そのメソッドをProgramクラスで実行する。
namespace EP403
{
    class Program
    {
        static void Main(string[] args)
        {
            Bingo bingo = new Bingo();
            while(true)
            {
                try
                {
                        Console.Write("ビンゴの作成サイズを入力 : ");
                        int size = int.Parse(Console.ReadLine());
                        if(size > 0)
                        {
                            Console.WriteLine();
                            bingo.Init(size);
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
