using System;

// 自動実装プロパティ実装例のプログラミング
// 自動実装プロパティ　フィールドを必要としないプロパティのこと
// 対応するフィールドがなくなるため(空の状態のままのため)、メソッド内でプロパティに対して、読み込み、書き込みの処理を行う必要がある
namespace Sample405
{
    class Person
    {
        public void SetAgeAndName(string name, int age)
        {
          Name = name;
          Age = age;
        }
        public void ShowAgeAndName()
        {
          Console.WriteLine("name:{0} age:{1}", Name, Age);
        }

        // プロパティに対してアクセス修飾子をつけることが可能　setかgetの片方にしかつけることはできない
        public string Name
        {
          private set;
          get;
        }
        public int Age
        {
          set; get;
        }
    }
}
