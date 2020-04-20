using System;

// 1から100までの乱数を10個生成し、それらを表示し、大きい順にならべかえるプログラム。
// 復習1回目
namespace EP308_re
{
    class Program
    {
        static void Main(string[] args)
        {
            // ランダムクラスのインスタンス生成
            Random random = new Random();
            // 生成する10個を格納する配列
            int[] numbers = new int[10];
            // 要素の代入
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //　max,pos変数の初期化
            int max = 0;
            int pos = 0;

            // 下記の処理を配列の要素の数だけ繰り返す
            for(int j = 0; j < numbers.Length; j++)
            {
                // 一番大きい値の取得
                for(int i = 0; i < numbers.Length; i++)
                {
                    if(max < numbers[i] )
                    {
                        max = numbers[i];
                        pos = i;
                    }
                }
                // 値の表示、表示した値を0にする
                Console.WriteLine(max);
                numbers[pos] = 0;
                // max変数をリセット
                max = 0;
            }
        }
    }
}
