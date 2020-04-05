using System;

namespace Sample403
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();

            p1.Name = "hiroto";
            p1.Age = 24;

            p2.SetAgeAndName("kento", 26);

            p1.ShowAgeAndName();

            Console.WriteLine("名前:{0} 年齢:{1}", p2.Name, p2.Age);
        }
    }
}
