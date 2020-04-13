using System;

namespace EP408
{
    class Hoo
    {
      // コンストラクタ
      public Hoo()
      {
        Console.WriteLine("Hooクラスのインスタンスが生成されました");
      }
      // デストラクタ
      ~Hoo()
      {
        Console.WriteLine("消去されました");
      }
    }
}
