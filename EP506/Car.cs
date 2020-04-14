using System;

namespace EP506
{
  class Car : IDriver, IMechanical
  {
    public void Drive()
    {
      Console.WriteLine("運転する");
    }
    public void Maintain()
    {
      Console.WriteLine("メンテナンスする");
    }
  }
}