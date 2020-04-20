using System;

namespace EP403
{
  class Bingo
  {
    // ビンゴのサイズ
    int size = 0;
    // int[,] bingo = new int[size, size];
    int[,] bingo;
    //入力に応じたビンゴカード作成するメソッド
    public void Init(int size)
    {
      this.size = size;
      bingo = new int[size, size];
      // ビンゴカードの初期化
      for(int i = 0; i < bingo.GetLength(0); i++)
      {
        for(int j = 0; j < bingo.GetLength(1); j++)
        {
          bingo[i, j] = 0;
        }
      }
      // サイズに対応した値をランダムに代入
      int num = 1;
      Random random = new Random();
      while( num <= size*size)
      {
        int m = random.Next(size);
        int n = random.Next(size);
        if(bingo[m, n] == 0)
        {
          bingo[m, n] = num;
          num++;
        }
      }
    }

    // ビンゴカードの表示
    public void Show()
    {
      for(int i = 0; i < bingo.GetLength(0); i++)
      {
        for(int j = 0; j < bingo.GetLength(1); j++)
        {
          Console.Write("{0, 2:d}|", bingo[i,j]);
        }
        Console.WriteLine();
        for(int j = 0; j < bingo.GetLength(1); j++)
        {
          Console.Write("---");
        }
        Console.WriteLine();
      }
    }
  }
}