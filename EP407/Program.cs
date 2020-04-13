using System;

// Studentクラスのインスタンを生成するときに、生徒の情報をコンストラクタを利用して登録し、登録した情報を表示するプログラム
namespace EP407
{
    class Program
    {
        static void Main(string[] args)
        {
            // Studentクラスの配列変数作成
            Student[] students = new Student[3];
            // Studentクラスのインスタンスを生成と配列への格納
            students[0] = new Student("hiro", 1, 15);
            students[1] = new Student("hana", 2, 16);
            students[2] = new Student("taiki", 3, 18);

            // 名簿の表示
            foreach( Student member in students)
            {
                member.SowInformation();
            }
        }
    }
}
