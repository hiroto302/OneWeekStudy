using System;

// 静的メンバについて学ぶプログラム
// 「静的メソッド」について
// 今までにも、Console.WriteLine などインスタンスを生成していないのConsoleクラスのWriteLineメソッドを扱えていたのは「静的メソッド」であったからである。
// また、インスタンスを生成しないと呼び出せないメソッドのことを「インスタンスメソッド」と呼ぶ
// 「静的フィールド」について
// わざわざインスタンを生成して呼び出す必要がないため、使用頻度の高い値や、同じクラス間で共通に保持したい値に使用する
// また、インスタンスを生成しないと呼び出せないフィールドのことを「インスタンスフィールド」と呼ぶ

namespace Sample501
{
    class Program
    {
        static void Main(string[] args)
        {
            Data[] d = new Data[2];
            // Dataのインスタンスの数を表示
            // static修飾子を付けた静的メンバであるShowNumberメソッドの呼び出し
            // クラス名.メソッド名
            Data.ShowNumber();

            // インスタンスを生成
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Data( i * 100);
                Data.ShowNumber();
            }
            // 静的フィールドの呼び出し
            Console.WriteLine(Data.num);
        }
    }
}
