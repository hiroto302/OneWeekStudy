using System;

// 性と名を入力し、フルネームを表示するプログラム
namespace Prob105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("性を入力 : ");
            string familyName = Console.ReadLine();
            Console.Write("名を入力 : ");
            string firstName = Console.ReadLine();
            string fullName = familyName + " " + firstName;
            Console.WriteLine("あなたの名前は、" + familyName + " " + firstName + "です");
            Console.WriteLine("あなたの名前は、" + fullName + "です");
        }
    }
}
