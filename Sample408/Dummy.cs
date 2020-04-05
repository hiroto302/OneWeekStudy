using System;

namespace Sample408
{
    class Dummy
    {
        public Dummy()
        {
          Console.WriteLine("コンストラクタ");
        }
        ~Dummy()
        {
          Console.WriteLine("デストラクタ");
        }
    }
}
