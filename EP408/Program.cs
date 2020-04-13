using System;

// デストラクタ確認するプログラム (デストラクタが発動しない....)
namespace EP408
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoo hoo1 = new Hoo();
            hoo1 = null;
        }
    }
}
