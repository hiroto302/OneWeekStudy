using System;

namespace Sample401
{
    // クラス　人間というオブジェクトの設計図がクラスにあたる
    // このクラスを基に、生成された実体がオブジェクトをインスタントと呼ぶ
    class Person
    {
        // 名前(フィールド)
        // オブジェクトのデータにあたるものをフィールドと呼ぶ
        public string name = "";
        // 年齢(フィールド)
        public int age = 0;
        // 情報の表示メソッド
        public void ShowAgeAndName()
        {
          Console.WriteLine("年齢:{0} 名前:{1}", age, name);
        }
        // 情報の設定
        // this 自分自身のインスタンを表す記号 オブジェクト指向における一人称にあたる this.name = 私の名前　のようなイメージ
        // フィールドと引数を明確に区別する必要がある時、利用する
        public void SetAgeAndName(string name, int age)
        {
          this.name = name;
          this.age = age;
        }
    }
}