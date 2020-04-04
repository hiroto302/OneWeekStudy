using System;

// 無限ループ
// 1~6の数字をランダムに生成し、6が出るまで無限に処理を繰り返すプログラム
namespace Sample304
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  //Randomクラスのインスタンス生成
            while(true)
            {
                int dice = rnd.Next(1, 7); // 1~7未満の数値を生成
                Console.WriteLine(dice);
                if( dice == 6 )
                {
                    break;
                }
            }
            Console.WriteLine("終了");
        }
    }
}
