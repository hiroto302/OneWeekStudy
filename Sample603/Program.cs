using System;
using System.Collections.Generic;

// Dictionaryクラスの実装例
// key と　value のペアでデータを保持し、データを管理する
// ハッシュテー、連想記憶と呼ばれいる

namespace Sample603
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionaryの宣言
            // Dictionary<key , value> 変数名
            Dictionary<string, string> capital = new Dictionary<string, string>();

            // データの追加
            capital["日本"] = "東京";
            capital["イギリス"] = "ロンドン";
            capital["フランス"] = "パリ";
            Console.WriteLine("世界の首都");
            // データの出力
            // ハッシュテーブルは、配列と違い、keyで管理しているのでインデックス(数値の番号)のように順序や前後関係が無い
            // なので、全ての内容を出力する場合、まずキーを全て取得する必要がある。
            // 変数名.Keys　で Dictionaryクラスに与えられたキーの一覧を配列として取得できる　なので,in 配列　の記述の中に記述できる
            foreach(string s in capital.Keys)
            {
                Console.WriteLine("{0}の首都は{1}", s, capital[s]);
            }
        }
    }
}
