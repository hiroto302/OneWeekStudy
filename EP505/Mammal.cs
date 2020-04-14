using System;

namespace EP505
{
  // 抽象クラス　哺乳類
  abstract class Mammal
  {
    // フィールド
    string name;

    // コンストラクタ 名前設定
    public Mammal(string name)
    {
      this.name = name;
    }

    public string Name
    {
      get{return name;}
    }

    // 抽象メソッド 鳴き声
    public abstract void Sing();
  }
}