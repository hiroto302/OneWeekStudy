using System;

// 抽象プロパティの実装例
namespace Sample509
{
  // 抽象クラス
  abstract class VectorBase
  {
    // 抽象プロパティ
    public abstract double X
    {
      set;
      get;
    }
    public abstract double Y
    {
      set;
      get;
    }
  }
}