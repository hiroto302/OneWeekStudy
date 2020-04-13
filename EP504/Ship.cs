using System;

// namespace Ship
namespace EP504
{
  class Ship
  {
    string name;
    public Ship(string name)
    {
      this.name = name;
      Console.WriteLine("{0}と名付けられた船が生成されたよ", this.name);
    }
    public void Sail()
    {
      Console.WriteLine("航行する");
    }
  }
}