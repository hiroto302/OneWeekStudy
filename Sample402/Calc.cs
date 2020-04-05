using System;


namespace Sample402
{
    class Calc
    {
      // 戻り値は、returnで返す。返される戻り値のデータの型は、メソッドの先頭で定義する型と一致させる。
      // オーバーロードについて
      // 同名でメソッドを複数定義することができる。ただし、引数や戻り値の型を異なる必要がある。
      // ほぼ同じ処理だけど条件などが微妙に違う処理の名前を統一することができる
      public int Add(int a, int b)
      {
        return a+b;
      }
      public int Add(int a, int b, int c)
      {
        return a+b;
      }
    }
}
