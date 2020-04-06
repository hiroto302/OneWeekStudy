using System;

namespace Sample503
{
  // 親となるクラス　(ベースクラス、親クラス、スーパークラス)
  // 下記のように子クラスを継承することはできない　循環する基底クラスの依存関係となるエラーになる
  class Calculator //: ExCalculator
  {
    // 修飾子 protected について
    // protectedは、private同様,他クラスからはアクセスできないが、子クラスからはアクセスすることができる修飾子
    protected int num1;
    protected int num2;
    public int Num1
    {
      set { num1 = value;}
      get { return num1;}
    }
    public int Num2
    {
      set { num2 = value;}
      get { return num2;}
    }
    public void Add()
    {
      Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
    }
    public void Sub()
    {
      Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
    }
  }
}