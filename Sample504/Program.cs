using System;

// 継承におけるコンストラクタについて学ぶプログラム
namespace Sample504
{
    class Program
    {
        static void Main(string[] args)
        {
            // 子クラスのインスタンスを生成すると、親のコストラクタ、子のコンストラクタの順序で実行される
            Console.WriteLine("引数なしでSubクラスのインスタンス生成");
            Sub s1 = new Sub();
            s1.showParam();

            // 引数ありで子クラスのインスタンスを生成すると、子クラスは引数を持つコンストラクタが呼び出される。
            // しかし、子クラスのコンストラクタで :base(引数) と指定しない限り、baseクラスの引数ありのコンストラクタが呼び出されない
            // 何も記述しないで指定しない場合、デフォルトで :base と同義で引数なしのコンストラクタが呼び出されてしまう
            Console.WriteLine("引数ありでSubクラスのインスタンス生成");
            Sub s2 = new Sub(100);
            s2.showParam();
        }
    }
}
