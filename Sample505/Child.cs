using System;

namespace Sample505
{
  class Child : Parent
  {
    public override void Foo()
    {
      Console.WriteLine("子クラスのFooメソッド");
    }
  }
}