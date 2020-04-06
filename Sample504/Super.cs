using System;

namespace Sample504
{
  class Super
  {
    // パラメーター
    protected int param = 0;
    // コンストラクタ
    public Super()
    {
      Console.WriteLine("Superクラスのコンストラクタ(引数なし)");
    }
    public Super(int param)
    {
      Console.WriteLine("Superクラスのコンストラクタ(引数:param = {0})", param);
      this.param = param;
    }
    // デストラクタ
    ~Super()
    {
      Console.WriteLine("Superクラスのデストラクタ");
    }
    // パラメーターの表示
    public void showParam()
    {
      Console.WriteLine("param = {0}", param);
    }
  }
}