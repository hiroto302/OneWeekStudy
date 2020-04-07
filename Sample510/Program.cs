using System;

namespace Sample510
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hoge@email.com", "000-000-1234");
            // 携帯電話クラスで、電話とメールを実行
            cp.Call("001-001-1234");
            cp.SendMail("fuga@email.com");
            // 電話インターフェ-スでインスタンスにアクセス
            // あるクラス(CellPoneクラス)を、ベースクラスやインターフェース(IPhone)の型に代入するときはキャストを利用
            // キャスト(IPhone)をつけて代入することで、CellPhoneクラスを架空のIPhoneクラスとして振舞うことができる
            IPhone phone = (IPhone)cp;
            phone.Call("002-002-1234");
            // メールインターフェースでインスタンスにアクセス
            IEmail mail = (IEmail)cp;
            mail.SendMail("bar@mail.com");
        }
    }
}
