using System;

// コンストラクタについて学ぶプログラム
// コンストラクタ　
// インスタンス生成時に一度だけ呼び出されるメソッド
// 戻り値がなく、クラス名と同じ名前のメソッド

namespace Sample406
{
    class Person
    {
        private string name = "";
        private int age = 0;
        // コンストラクタ引数なし :thisをつけることでこのメソッドを呼ぶ前に引数ありのコンストラクタが呼ばれる
        public Person() : this("名無し", 0)
        {
          Console.WriteLine("引数なしコンストラクタ");
        }
        // コンストラクタ引数あり
        public Person(string name, int age)
        {
          this.name = name;
          this.age = age;
          Console.WriteLine("name:{0} age:{1}", name, age);
        }

        public void ShowAgeAndName()
        {
          Console.WriteLine("name:{0} age:{1}", name, age);
        }
        public string Name
        {
          set {name = value;}
          get {return name;}
        }
        public int Age
        {
          set {age = value;}
          get {return age;}
        }
    }
}