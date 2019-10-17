Singletonサンプル
====


## Description
### 

- シングルトンパターンのお勉強

```c#
using System;

namespace SingletonSample.Singleton
{
    /// <summary>
    /// シングルトンパターン
    /// </summary>
    public class Singleton1 : IAPI
    {
        /// <summary>
        /// フィールド変数にnewする
        /// </summary>
        private static Singleton1 _singleton1 = new Singleton1();

        /// <summary>
        /// このメソッドを使用してsingleton1クラスのインスタンスを取得する
        /// </summary>
        /// <returns></returns>
        public static Singleton1 GetInstance() => _singleton1;
        
        /// <summary>
        /// privateにして他クラスからnewできなくする
        /// </summary>
        private Singleton1()
        { }

        /// <summary>
        /// hogehogeいうだけのメソッド
        /// </summary>
        public void Hello() => Console.WriteLine($"hogehoge : {Name}");

        /// <summary>
        /// 文字列をSet・Getするプロパティ
        /// </summary>
        public string Name { get; set; }
    }
}
```

フィールド変数宣言時にnewする通常？パターンと遅延生成させるパターンを用意しました

## Author
pisa