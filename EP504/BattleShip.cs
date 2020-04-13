using System;

namespace EP504
{
  // 下記は、Shipクラスが格納されているnamespaceをShipにした時の書き方 namespaceがShipのShipクラスを継承
  // class BattleShip : Ship.Ship
  class BattleShip : Ship
  {
    public BattleShip() : base("大和")
    {
      Console.WriteLine("親クラスのコンストラクタ利用");
    }
    public void Fight()
    {
      Console.WriteLine("戦闘する");
    }
  }
}