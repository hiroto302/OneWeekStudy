using System;

namespace EP401
{
  // 長方形クラス
  class Rectangle
  {
    // フィールド
    // 幅
    public double width;
    // 高さ
    public double height;

    // 面積の取得
    public double GetArea(double width, double height)
    {
      this.width = width;
      this.height = height;
      return this.width * this.height;
    }
    // 周の長さ取得
    public double GetPerimeter(double width, double height)
    {
      this.width = width;
      this.height = height;
      return this.width * 2 + this.height * 2;
    }
  }
}