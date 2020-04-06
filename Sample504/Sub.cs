using System;

namespace Sample504
{
  class Sub : Super
  {
    // Subクラスのコンストラクタ
    public Sub()
    {
      Console.WriteLine("Subクラスのコンストラクタ(引数なし)");
    }
    public Sub(int subParam) : base(subParam)
    {
      Console.WriteLine("Subクラスのコンストラクタ(引数:subParam = {0})", subParam);
    }
    // Subクラスのデストラクタ
    ~Sub()
    {
      Console.WriteLine("Subクラスのデストラクタ");
    }
  }
}