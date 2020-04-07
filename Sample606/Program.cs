using System;

// 複数メソッドのデリケート実装例
namespace Sample606
{
    class Program
    {
        // デリゲートの宣言
        delegate void Action(int a);
        static void Func1(int a)
        {
            Console.WriteLine(1 + a);
        }
        static void Func2(int a)
        {
            Console.WriteLine(2 + a);
        }
        static void Func3(int a)
        {
            Console.WriteLine(3 + a);
        }
        static void Main(string[] args)
        {
            // デリゲートにメソッドを追加する
            // 同型であれば複数のメソッドを、一つのデリゲートオブジェクトaに追加することができる
            Action a = new Action(Func1);
            a += new Action(Func2);
            a += new Action(Func3);

            // 処理の実行
            // それぞれのメソッドの引数に3を渡し,実行する
            a(3);
        }
    }
}
