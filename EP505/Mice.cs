using System;

namespace EP505
{
  class Mice : Mammal
  {
    public string personalName;
    public Mice(string personalName) : base("ネズミ")
    {
      this.personalName = personalName;
    }

    public override void Sing()
    {
      Console.WriteLine("チューチュー");
    }
  }
}