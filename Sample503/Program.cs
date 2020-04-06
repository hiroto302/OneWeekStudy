using System;

namespace Sample503
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c1の四則演算結果");
            Calculator c1 = new Calculator();
            c1.Num1 = 10;
            c1.Num2 = 3;
            c1.Add();
            c1.Sub();
            // 親クラスは子クラスのメソッドを利用できない(継承していないから他クラスのメソッドは利用できない)
            // c1.Div();

            Console.WriteLine("c２の四則演算結果");
            ExCalculator c2 = new ExCalculator();
            // 継承している親クラスのプロパティ、メソッド、フィールドなどの記述内容を、子クラスは利用することができる
            c2.Num1 = 10;
            c2.Num2 = 3;
            c2.Add();
            c2.Sub();
            c2.Mul();
            c2.Div();
        }
    }
}
