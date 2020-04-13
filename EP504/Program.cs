using System;

// Shipクラスを継承したBattleShipクラス（戦闘機能を追加)を作成し、戦闘メソッドを実行する
namespace EP504
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleShip battleShip = new BattleShip();
            battleShip.Sail();
            battleShip.Fight();
        }
    }
}
