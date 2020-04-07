using System;
using System.Collections.Generic;

// List データ削除の実装例
namespace Sample602
{
    class Program
    {
        static void Main(string[] args)
        {
            // 部員リスト
            List<string> nameList = new List<string>();
            nameList.Add("hiro");
            nameList.Add("kouji");
            nameList.Add("sin");
            nameList.Add("ari");
            nameList.Add("kai");
            nameList.Add("taka");
            nameList.Add("muro");
            nameList.Add("seki");

            // 喧嘩した部員の試合出場停止
            // 指定したデータの削除
            nameList.Remove("muro");
            // 指定したインデックスの削除
            nameList.RemoveAt(0);

            for(int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }
        }
    }
}
