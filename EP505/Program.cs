using System;

// 抽象クラスMammalsクラスとそれを継承した、Cat,Miceクラスを作成し各名前と鳴き声を表したメソッドを実行するプログラム
namespace EP505
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] m = new Mammal[2];
            m[0] = new Cat("ニャース");
            m[1] = new Mice("ピカチュウ");

            Cat c1 = new Cat("ニャース");
            Mice m1 = new Mice("ピカチュウ");

            foreach(Mammal a in m)
            {
                Console.WriteLine("種類:{0}", a.Name);
                a.Sing();
                Console.WriteLine("---------------");
                // personalNameを抽象クラスが持っていないので下記は実行できない
                // Console.WriteLine("名前:{0}", a.personalName);
            }
            Console.WriteLine("猫の名は{0},相棒は{1}", c1.personalName, m1.personalName);
        }
    }
}
