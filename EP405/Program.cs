using System;

// コンソールから入力された文字列の長さを表示するプログラ
//　strignクラスのプロパティの利用
namespace EP405
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力してください : ");
            string text = Console.ReadLine();
            // stringクラス.Lengthプロパティ 文字列の数を返す(おそらく、ゲッター(get)でretrun 文字数の処理がなされている。)
            Console.WriteLine("文字数 : {0}", text.Length);
        }
    }
}
