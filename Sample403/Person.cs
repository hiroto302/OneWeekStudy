using System;

// カプセル化について学んでいく
// カプセル化　複雑な仕組みをなるべく隠蔽し、必要最低限の操作で外部から操作できるようにする考え方をカプセル化と呼ぶ
// アクセス修飾子とプロパティについて学ぶプログラム
// アクセス修飾子　フィールドおよびメソッドへのアクセスを制限するためのもの
// プロパティ　セッター / ゲッター を一つのメソッドで記述できるメソッド
namespace Sample403
{
    class Person
    {
        private string name = "";
        private int age = 0;
        public void SetAgeAndName(string name, int age)
        {
          this.name = name;
          this.age = age;
        }
        public void ShowAgeAndName()
        {
          Console.WriteLine("名前:{0} 年齢{1}", name, age);
        }

        // プロパティ
        // フィールド名の先頭を大文字にしたものをプロパティと呼ぶ
        public string Name
        {
          // セッター フィールドの値を設定するためのメソッドのこと
          // {}内に値変更時の処理を記述 valueという名前の変数に代入された値が格納される

          set { name = value;}
          // ゲッター フィールドの値を取得するためのメソッドのこと
          // {}内にreturnを用いて、値取得時の処理を記述
          get { return name;}
        }
        public int Age
        {
          set { age = value;}
          get { return age;}
        }
    }
}