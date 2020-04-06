using System;

namespace Sample503
{
  // 子となるクラス (サブクラス、子クラス)
  // Calculatorクラスを継承したExCalculatorクラス
  // 親クラスは子クラスを複数作ることができるが、子クラスは親となるクラスを一つしか持つことができない
  // C#において、上記のように親クラスを一つだけ継承することができる仕組みを　単一継承　と呼ぶ
  // 他言語では、複数の親クラスを継承できる仕組みがあり　多重継承　と呼ぶ
  class ExCalculator : Calculator
  {
    public void Mul()
    {
      Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
    }
    public void Div()
    {
      Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
    }
  }
}