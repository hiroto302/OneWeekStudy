using System;

// インターフェースと抽象クラスの違いについて学ぶプログラム
// IFuncs1 とIFuncs2 にそれぞれFunc2()メソッドが含まれている。
// つまり、インターフェースはクラスの一部を切り取るたものものであり、メソッドのメソッドの重複があっても構わない
// 継承は、あるクラスの機能を受け継ぎ、それをさらに拡張するというもの、また単一継承であり根本的に考え方が違う
namespace Sample511
{
    class Program
    {
        static void Main(string[] args)
        {
            Dummy d = new Dummy();
            IFuncs1 i1 = (IFuncs1)d;
            IFuncs2 i2 = (IFuncs2)d;
            i1.Func1;
            i1.Func2;
            i2.Func2;
            i2.Func3;
        }
    }
}
