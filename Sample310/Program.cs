using System;

// ジャグ配列
// 配列の中に配列が入ったもの
// 二次元配列　a[m,n]　をジャグ配列では　a[m][n]
namespace Sample310
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][]
            {
                new int[] {0, 1},       //縦0列目(ジャグ配列の中の0番目の配列)の横0列目と1列目の要素に0と１をそれぞれ代入　m=0 , a[m].Length = 2
                new int[] {2},          //縦1列目(ジャグ配列の中の1番目の配列) m=1, a[m].Length = 1
                new int[] {3, 4, 5, 6}  //縦2列目(ジャグ配列の中の2番目の配列) m=2, a[m].Length = 4
            };
            Console.WriteLine(a[0].Length);
            // 要素の表示
            // a.Length = 3   ジャグ配列 a に格納している配列の数をさす
            for(int m = 0; m < a.Length; m++)
            {
                // a[m].Length ジャグ配列 a に格納してあるm番目の配列の要素の数
                for(int n = 0; n < a[m].Length; n++)
                {
                    Console.Write(a[m][n] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
