using System;

// ガーベージコレクションを学ぶプログラム
// インスタンが生成されると、その分メモリが消費される。 そのため不要なインスタンスを整理するためにGarbageCollectionを用いる


namespace Sample407
{
    class Program
    {
        static void Main(string[] args)
        {
            // メモリを消費するための記述
            string[] a = new string[10000];
            for(int i = 0; i < a.Length; i++)
            {
                // Stringクラスのコンストラクタメソッド 文字Mを10000個連ねた文字列を配列の要素1つに代入
                a[i] = new String('M', 10000);
            }

            // メモリ使用量の参照
            Console.WriteLine("メモリ使用量(GC発動前) : " + GC.GetTotalMemory(false));

            // aの参照を解放　nullを代入することで変数aがどんなインスタンスも参照していない状態にする
            // これにより、そのインスタンスはメモリ内に存在するが使用されていない状態になる
            a = null;

            Console.WriteLine("メモリ使用量(参照解除後) : " + GC.GetTotalMemory(false));
            // 使用されていないメモリ(インスタンス)を強制排除
            GC.Collect();
            Console.WriteLine("メモリ使用量(GC発動後) : " + GC.GetTotalMemory(false));
        }
    }
}
