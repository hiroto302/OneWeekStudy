using System;

namespace Sample405
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            // p1.SetAgeAndName("hiroto", 24);
            // p1.ShowAgeAndName();

            // Nameプロパティをprivate setにし、読み取り専用プロパティにしているため下記の記述で値をセットできない
            // p1.Name = "hiroto";
            p1.Age = 17;
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
        }
    }
}
