using System;

namespace Sample508
{
  // 抽象クラス
  // abstract 修飾子を用いる
  // このクラスの目的は、「継承してサブクラスを作る」という設計を強制することである

  // 抽象クラスはインスタンスを生成することができない
  // 抽象クラスを継承した子クラスが、インスタンを生成することができる
  abstract class Bird
  {
    private string name;
    // 生成する鳥の名前 コンストラクタ
    // 抽象クラスであるので、このクラスを継承したクラスのインスタンスが生成される時利用することを想定に作成
    public Bird(string name)
    {
      this.name = name;
    }

    public string Name
    {
      get{ return name; }
    }
    // 鳥の鳴き声　抽象メソッド
    // 抽象メソッドの処理の実装は、継承したサブクラスで行う
    public abstract void Sing();
  }
}

