using System;

// 個々の処理をメソッド化することで、ソースコードの可読性を上げ、今後同じような処理が必要な時にメソッドを呼び出すだけで済むようした
namespace EP406
{
  class Bingo
  {
    // ビンゴのサイズ
    private int size = 0;
    private int[,] bingo;
    //入力に応じたビンゴカード作成するメソッド
    public void Init(int size)
    {
      this.size = size;
      bingo = new int[size, size];
      // ビンゴカードの初期化
      Clear();
      // サイズに対応した値をランダムに代入
      Shuffle();
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

    // bingoの値を全て0にするメソッド
    private void Clear()
    {
      for(int i = 0; i < bingo.GetLength(0); i++)
      {
        for(int j = 0; j < bingo.GetLength(1); j++)
        {
          bingo[i, j] = 0;
        }
      }
    }
    // 数値をランダムに配置するメソッド
    private void Shuffle()
    {
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
  }
}