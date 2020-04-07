using System;

// インターフェースの実装例
// インターフェースの役割は抽象クラスに似ている。しかし、抽象クラスと違いインターフェースは複数実装可能である。
// 1つのクラスに複数の側面がある場合によく用い入れる
// 実装がないメソッドの集合のようなもの
// ただし、インターフェース内では、フィールドや、メソッドの処理の内容を持つことができない
// そのため、インターフェース内で定義されメソッドをクラスで実装する必要がある。
// なのでインターフェスのメソッドの修飾子は全てpublicであることが前提である
// インターフェース名は、I (大文字のi)から始めることが推奨されている命名法である


namespace Sample510
{
  // 携帯電話クラス  IPhone, IEmailクラスの実装
  class CellPhone : IPhone, IEmail
  {
    // メールアドレス
    private string mailAddress;
    // 電話番号
    private string number;
    // コンストラクタ 生成時にアドレスと電話番号を設定
    public CellPhone(string mailAddress, string number)
    {
      this.mailAddress = mailAddress;
      this.number = number;
    }
    // SendMailの実装
    public void SendMail(string address)
    {
      Console.WriteLine(address + "に、" + this.mailAddress + "からメールを出します");
    }
    // Callの実装
    public void Call(string number)
    {
      Console.WriteLine(number + "に、" + this.number + "から電話をかけます");
    }
  }
}