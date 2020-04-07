using System;
using System.Collections.Generic;
// Collectionは、様々なデータ群を扱うクラス群
// namaspace System.Collections.Genericに含まれている

// ジェネリックについて
// 簡単にいうと、特定の型、もしくはクラスに依存しないクラスやメソッド記述するための仕組みのことをジェネリックと呼ぶ
// この仕組みのおかげで、int, string型などをArrayListクラスは同じように配列のように扱うことができる


// Listの実装例 データの追加
// 可変可能な配列のような配列のようなデータ構造のクラス
namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            // 配列との書き方の違い
            // int[] a = new int[n];

            // Listの宣言
            // List<型/クラス名> 変数名 = new List<型/クラス名>();
            // List a　作成
            List<int> a = new List<int>();

            // 値を順に挿入
            a.Add(3);
            a.Add(2);
            a.Add(1);
            // 箇所を指定して値を挿入
            a.Insert(1, 4); //index, item  一番目に4の値を挿入

            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

        }
    }
}
