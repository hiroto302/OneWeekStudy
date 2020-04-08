using System;

// 文字列を5回入力し、その全てを表示するプログラム
namespace Prob403
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[5];
            // 配列の一つ目は0番目なので、初期値で0以外の数値を使うのは気をつけること
            int n = 0;
            // 下記の記述で1から始めると,二番目の箱に1回目の記述内容が保持されてしまう
            // int n = 1;
            while( n < text.Length)
            {
                Console.Write("{0}回目 文字列を入力 : ", n + 1);
                text[n] = Console.ReadLine();
                n ++;
            }
            foreach( string a in text)
            {
                Console.WriteLine(a);
            }
        }
    }
}
