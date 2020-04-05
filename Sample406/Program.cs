using System;

namespace Sample406
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person(); // 引数なしのコンストラクタ
            p2 = new Person("hiroto", 17); // 引数ありのコンストラクタ

            p1.Name = "hiroko";
            p1.Age = 16;
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}
