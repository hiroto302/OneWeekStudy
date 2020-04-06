using System;

namespace Sample508
{
  // 抽象クラスを継承したCrowクラス
  class Crow : Bird
  {
    // Crowクラスのインスタンを生成すると親クラス(抽象クラス)であるBirdのコンストラクタも呼ばれる。
    public Crow() : base("カラス")
    {
      // 生成する鳥の名前
    }
    // カラスの鳴き声 抽象メソッド public abstract void Sing()の上書き（オーバーライド）
    public override void Sing()
    {
      Console.WriteLine("カーカー");
    }
  }
}