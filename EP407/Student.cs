using System;

namespace EP407
{
    class Student
    {
        // フィールド　名前、学年、年齢
        private string name;
        private int grade;
        private int age;

        // コンストラクタ
        public Student(string name, int grade, int age)
        {
            SetInformation(name, grade, age);
        }

        public void SetInformation(string name, int grade, int age)
        {
            this.name = name;
            this.grade = grade;
            this.age = age;
        }
        // 情報の表示
        public void SowInformation()
        {
            Console.WriteLine("名前: {0} 学年: {1} 年齢: {2}", name, grade, age);
        }
    }
}
