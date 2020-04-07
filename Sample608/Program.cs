using System;

// 例外を意図的に発生させる
namespace Sample608
{
    class Program
    {
        static int GetNum(int i)
        {
            int[] nums = {300, 600, 900};
            if(i > nums.Length)
            {
                // throw を用いて意図的に例外を発生
                // throw new 例外クラス名(コンストラクタの引数, ...);
                Console.WriteLine("throw発生");
                throw new IndexOutOfRangeException();
            }
            return nums[i];
        }
        static void Main(string[] args)
        {
            try
            {
                int result = GetNum(4);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("catch発動");
                Console.WriteLine("配列の範囲外にアクセスしました");
            }
        }
    }
}
