using System;

// インターフェースを利用し、車は運転およびメンテナンスはできるが、運転は運転者のみ、メンテナンスは整備士のみできるようにするプログラム
namespace EP506
{
    class Program
    {
        // インターフェースであるIDriverを継承しているCarクラスのインスタンス変数を引数にとると自動でキャストしてインターフェスの架空のクラス変数になってくれる
        static void DriveACar(IDriver driver)
        {
            driver.Drive();
        }
        static void MaintainCar(IMechanical mechanical)
        {
            mechanical.Maintain();
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            IDriver driver = (IDriver)car;
            IMechanical mechanical = (IMechanical)car;

            driver.Drive();
            mechanical.Maintain();

            DriveACar(car);
            MaintainCar(car);
        }
    }
}
