using System;

// コンストラクタの追加
namespace EP409
{
  class Bingo
  {
    // ビンゴのサイズ
    private int size = 0;
    private int[,] bingo;

    // 引数なしのコンストラクタ 5*5のビンゴカード作成
    public Bingo() : this(5)
    {
      // Init(5);
    }
    // 引数ありのコンストラクタ 引数にsizeを受け取り、対応したビンゴカードを作成
    public Bingo(int size)
    {
      Init(size);
    }
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