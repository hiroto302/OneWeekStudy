using System;

// 数当てゲーム 0~10の乱数をランダムに生成し、その値を3回の回答の内に当てるゲーム
namespace EP303
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(0, 11);
            // int n = random.Next(11); 引数一つでの場合, 0 ~ 引数未満の数値を生成する
            Console.WriteLine("数当てゲーム");
            Console.Write("0~10の値を入力してください");
            int count = 1;
            while( count <= 3)
            {
                Console.Write("{0}回目 : ", count);
                int answer = int.Parse(Console.ReadLine());
                if( n == answer)
                {
                    Console.WriteLine("正解です");
                    break;
                }
                else if( n < answer)
                {
                    Console.WriteLine("大きすぎます");
                }
                else if ( n > answer)
                {
                    Console.WriteLine("小さすぎます");
                }
                count++;
            }
            if(count > 3)
            {
                Console.WriteLine("ゲームオーバーです");
                Console.WriteLine("正解は、{0}です", n);
            }
        }
    }
}
