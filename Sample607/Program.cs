using System;

// 例外処理について
// プログラミングを実行した時、予期せぬエラーのことを例外と呼ぶ
// 例外が生じた時、それを検知し、何らかの処理を行うことを例外処理という。try ~ catch プロックを使用。

// 例外クラスについて
// DivideByZeroExceptionは、例外クラスの一つで0で割り算して例外が発生した時にインスタンスが生成される
// 様々な例外クラスがあり、いずれも Exception クラスを継承している
namespace Sample607
{
    class Program
    {
        // 計算処理(例外を発生させる)
        private static int calc(int a, int b)
        {
            return a / b;
        }
        // 範囲外に出た時の処理
        public static int getNum(int index)
        {
            // 4つの要素を持つ配列を生成
            int[] num = { 0, 1, 2, 3, 4};
            return num[index];
        }
        static void Main(string[] args)
        {
            // 行う処理
            try
            {
                // i に 5が代入された時,IndexOutOfRangeExceptionが呼ばれる
                for (int i = 0; i <= 5; i++)
                {
                    int a = getNum(i);

                    int b = 5;
                    // b に 5 が代入された時,DivideByZeroExceptionが呼ばれる
                    // int b = 0;
                    Console.Write( a + " / " + b + " = ");
                    Console.WriteLine(calc(a, b));
                }
            }
            // 例外が生じた時の処理 複数作成可能
            // catch (例外クラス名 変数)
            catch (DivideByZeroException e)
            {
                Console.WriteLine();
                Console.WriteLine("0による割り算発生");
            }
            // getNum(5)の時、下記の処理実行
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("配列の範囲外にアクセスしました");
            }
            // 例外処理catch、エラーなく処理を完了した時呼ばれる
            // 省略可
            finally
            {
                Console.WriteLine("終了");
            }
        }
    }
}
