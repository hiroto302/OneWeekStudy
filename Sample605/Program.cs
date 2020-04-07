using System;

// デリゲートについて学ぶプログラム
// 他のクラスのメソッドを参照するオブジェクトのことを指す
// デリゲートを使用するメリット
// 処理を任せる側は、実際に処理をするのはどのクラスなのか、どんな処理をするのか、ということを全く意識しないで良い点である
namespace Sample605
{
    // デリゲートの宣言
    // delegate 戻り値の型 デリゲート名(引数のリスト)
    // 同一の戻り値の型、引数をとるメソッドを、オプジェクトとして利用できるようになる
    delegate void Operation(int a , int b);
    // Calcクラス
    class Calc
    {
        public void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a-b);
        }
    }
    // Programクラス
    class Program
    {
        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Main(string[] args)
        {
            Calc c = new Calc();

            // デリゲートに設定
            // ProgramクラスのAddメソッドを参照
            Operation o1 = new Operation(Add);
            // CalcクラスのSubメソッドを参照
            Operation o2 = new Operation(c.Sub);

            // デリゲートで設定したメソッドの呼び出し
            o1(2, 1);
            o2(2, 1);
        }
    }
}
