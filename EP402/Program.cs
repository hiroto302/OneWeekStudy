using System;

// コンソールで入力された文字列を大文字と、小文字にして返すプログラム
// エイリアスについて
// stringは、String のエイリアス（別名)である。以前,文字列のデータの型をstring を String としても問題だく動作するのはエイリアスが関係していた。

namespace EP402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力 : ");
            // どちらでも問題なく動作することの確認　strign String
            // String text = Console.ReadLine();
            string text = Console.ReadLine();
            Console.WriteLine("大文字 : {0}", text.ToUpper());
            Console.WriteLine("小文字 : {0}", text.ToLower());
        }
    }
}
