using System;

namespace EP505
{
  class Cat : Mammal
  {

    public string personalName;
    public Cat(string personalName) : base("猫")
    {
      this.personalName = personalName;
    }

    public override void Sing()
    {
      Console.WriteLine("ニャーニャー");
    }
  }
}