using System;

// Mainメソッドも静的メソッドであることを学ぶプログラム
// Mainメソッドについて
// Mainメソッドは、プログラムが実行される時に呼び出される処理が記述される特殊なメソッド
// プログラムの実行を開始する場所という意味でエントリーポイントと呼ぶ
// このメソッドは、一つのプロジェクトに一つしか作ることができない。言い換えると、Mainメソッドを持つクラス(Program)は、一つのネームスペースに一つである。

// 下記には、今まで実行処理のみ記述してきたMainメソッドのあるProgramクラスの中に、フィールドやメソッドも記述した例
namespace Sample502
{
    class Program
    {
        // staticフィールド
        private static int snum = 100;
        // インスタンスフィールド
        public int inum = 200;
        // staticメソッド
        public static void Foo()
        {
            Console.WriteLine("Fooメソッドはstaticメソッド");
        }
        // インスタンスメソッド
        public void bar(Program p)
        {
            Console.WriteLine("barメソッドはインスタンスメソッド");
            // インスタンスメソッド内であればインタンスフィールドのインスタンス変数省略可
            // 今回は確認のためにProgramクラスのインスタンス変数を引数に記述
            Console.WriteLine(p.inum);
            // インスタンスメソッド内でも静的メンバを利用できる
            Console.WriteLine(snum);
        }

        static void Main(string[] args)
        {
            //同じクラスでは,静的メンバは最初のクラス名省略可
            // Console.WriteLine(Program.snum);
            Console.WriteLine(snum);
            Foo();

            //クラス内で自分自身のインスタンスを生成することも可能
            // インスタンスメソッド・フィールドはインスタンを生成する必要がある
            Program p = new Program();
            p.bar(p);
            // インスタンスメソッドは省略不可
            //bar();

        }
    }
}
