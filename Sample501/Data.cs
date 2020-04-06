using System;

// static修飾子
// 他クラスのフィールド・メソッドを利用する時、インスタンスを生成せずに扱うことができるものを静的メンバと呼ぶ
// static修飾子をつけることで簡易的に定義できる
namespace Sample501
{
    class Data
    {
        // Dataオブジェクトの数
        public static int num = 0;
        // データの値
        private int id;
        // コンストラクタ
        public Data(int id)
        {
          this.id = id;
          num++;
          Console.WriteLine("id:{0} num:{1}", this.id, num);
        }
        public static void ShowNumber()
        {
          Console.WriteLine("num:{0}", num);
        }
    }
}
