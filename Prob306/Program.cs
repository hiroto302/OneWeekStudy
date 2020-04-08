using System;

// 入力した文字を返し、何も入力さずにEnterを押した時終了するプログラム
namespace Prob306
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("文字を入力 : ");
                string text = Console.ReadLine();
                if( text == "")
                {
                    break;
                }
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}
