using System;

namespace EP404
{
  // 長方形クラス
  class Rectangle
  {
    // フィールド
    // 幅
    private double width;
    // 高さ
    private double height;

    // 面積の取得
    public double GetArea()
    {
      return width * height;
    }
    // 周の長さ取得
    public double GetPerimeter()
    {
      return width * 2 + height * 2;
    }

    public double Width
    {
      set{ width = value;}
      get{ return width;}
    }
    public double Height
    {
      set{ height = value;}
      get{ return height;}
    }
  }
}