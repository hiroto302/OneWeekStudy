using System;

// 暗黙の継承について学ぶプログラム
// オブジェクトクラスについて
// C#の全てのクラスは、Objectというクラスを暗黙のうちに継承している
namespace Sample506
{
    class Program
    {
        public void Foo()
        {
            Console.WriteLine("Foo");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // Programクラスは、Fooメソッドは作成しているが、下記のメソッドを扱うことができる
            // これは、暗黙にオブジェクトクラスを継承し、オブジェクトクラスのメソッドを実行できている
            // オブジェクトクラスのメソッドの代表例
            Console.WriteLine(p.ToString()); // オブジェクトを表す文字列を返す　　　　Sample506.Program
            Console.WriteLine(p.GetType());  // オブジェクトのタイプを返す　　　　　　Sample506.Program
            Console.WriteLine(p.Equals(p));  // 引数のオブジェクトと等しいか調べる　　True
        }
    }
}
