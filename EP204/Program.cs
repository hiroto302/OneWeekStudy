using System;

// 条件分岐　if , switch文
namespace EP204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("日数を知りたい月(1~12)を入力 : ");
            int m = int.Parse(Console.ReadLine());

            string d = "";  //空の文字列の初期化

            // if文での記述
            // if ( m >= 1 && m <= 12)
            // {
            //     if( m == 2)
            //     {
            //         d = "28か29";
            //     }
            //     else if( m == 4 || m == 6 || m == 9 || m == 11)
            //     {
            //         d = "30";
            //     }
            //     else
            //     {
            //         d = "31";
            //     }
            //     Console.WriteLine( m + "の日数は" + d);
            // }
            // else
            // {
            //     Console.WriteLine("適切な値を入力してください");
            // }

            // switch文での記述
            switch (m)
            {
                case 2:
                    d = "28か29";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = "30";
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = "31";
                    break;
                default:     // elseにあたる
                    Console.WriteLine("適切な値を入力して下さい");
                    return;  // retrunによりここまでの処理を返すことで終了させる
                             // defaultのみbreakを省略可

            }
            Console.WriteLine("{0}月の日数の長さは{1}日です", m, d);
        }
    }
}
