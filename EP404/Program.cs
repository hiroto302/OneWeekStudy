using System;

// EP401で作成したRectangleクラスをプロパティを利用すて実装するプログラム
namespace EP404
{
    class Program
    {
        static void Main(string[] args)
        {
            // 長方形のインスタンス生成
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("求める長方形の高さ、幅を入力してください");
            // プロパティへの入力
            Console.Write("幅  : ");
            rectangle.Width = double.Parse(Console.ReadLine());
            Console.Write("高さ : ");
            rectangle.Height = double.Parse(Console.ReadLine());
            // メソッドの実行
            Console.WriteLine("面積 : {0}", rectangle.GetArea());
            Console.WriteLine("周 ： {0}", rectangle.GetPerimeter());
        }
    }
}
