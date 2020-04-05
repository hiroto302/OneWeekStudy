using System;

// オブジェクト思考の実装例。
namespace Sample401
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personクラス型の変数
            Person p1, p2;
            // Personクラスのメソッドのインスタンスを生成
            // インスタンス　＝　実例
            // 変数p1,p2はPersonクラスのインスタンを参照
            p1 = new Person();
            p2 = new Person();

            // インスタンスp1,p2にそれぞれ情報を与える方法
            // 各フィールドに値を代入する方法
            p1.name = "hiroto";
            p1.age = 24;
            // メソッドを活用
            p2.SetAgeAndName("kento", 26);

            // 各インスタンスの情報表示
            p1.ShowAgeAndName();
            p2.ShowAgeAndName();
        }
    }
}