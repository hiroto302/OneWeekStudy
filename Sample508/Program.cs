using System;

// 抽象クラスについて学ぶプログラミング
// また、String と　stringの違いについて検証したプログラム
namespace Sample508
{
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.Write(c.Name + " : ");
            c.Sing();
            Console.Write(s.Name + " : ");
            s.Sing();

            // 抽象クラスは、インスタンスは作成できないが抽象クラスの変数として使うことができる
            // 上記の書き換え
            // 下記のように、変数として値を保存することができる
            // ただし、抽象クラス Bird の変数birdsに代入可能なインスタンスは、そのクラスを継承したサブクラスに限る
            Bird[] birds = new Bird[2];
            birds[0] = new Crow();
            birds[1] = new Sparrow();
            for(int i = 0; i < birds.Length; i++)
            {
                Console.WriteLine(birds[i].Name);
                birds[i].Sing();
            }


            // 参考例では変数の型名に頭文字大文字で文字列の型が書かれていたので、小文字と違うか検証した
            // 実行結果は、bとなりStringの型とstringは同一なのか??タイプは同じであった Systemについてもう少し踏み込めばわかるかも
            // ちなみに int と　Int　のパターンではエラーとなる。
            // String name = "a";
            // string rename = "b";
            // Console.WriteLine(name.GetType());    // オブジェクトのタイプ　System.String
            // Console.WriteLine(rename.GetType());  // オブジェクトのタイプ　System.String
            // name = rename;
            // Console.WriteLine(name);
        }
    }
}
