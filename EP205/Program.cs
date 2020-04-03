using System;

namespace EP205
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Helloと入力して下さい : ");
            string m = Console.ReadLine();
            // if( m == "Hello")
            // stringクラスのEqualsの活用 第２引数にオプションを追加できる
            // if( m.Equals("Hello"))
            if( m.Equals("Hello", StringComparison.OrdinalIgnoreCase)) //大文字と小文字を比較しないオプション
            {
                Console.WriteLine("{0}が入力されました。", m);
            }
            else
            {
                Console.WriteLine("Helloと入力してください");
            }
        }
    }
}
