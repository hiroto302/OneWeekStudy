using System;

namespace Sample510
{
  // 電子メールインターフェイス
  interface IEmail
  {
    // 指定した相手のアドレスにメールを送る
    void SendMail(string address);
  }
}