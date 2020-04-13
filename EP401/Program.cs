using System;

// 長方形を表すクラスを作成し、入力された高さ、幅から面積と周の長さを求めるプログラム
namespace EP401
{
    class Program
    {
        static void Main(string[] args)
        {
            // 長方形のインスタンス生成
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("求める長方形の高さ、幅を入力してください");
            Console.Write("幅  : ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("高さ : ");
            double h = double.Parse(Console.ReadLine());

            double a = rectangle.GetArea(w, h);
            Console.WriteLine("面積 : {0}", a);
            double p = rectangle.GetPerimeter(w, h);
            Console.WriteLine("周 ： {0}", p);
        }
    }
}
