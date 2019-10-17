using SingletonSample.Class;
using SingletonSample.Singleton;
using System;

namespace SingletonSample
{
    /// <summary>
    /// スタートアップクラス
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// 処理
        /// </summary>
        public static void Main()
        {
            // step1
            Console.WriteLine("-Step1-");
            // var s = new Singleton1(); // new演算子はアクセスできないレベルにしている

            var s1 = Singleton1.GetInstance(); // Singleton1クラスのインスタンス取得
            var s2 = Singleton2.GetInstance(); // Singleton2クラスのインスタンス取得
            var n = new Normal("pisa");


            // Helloメソッドの内容を表示
            // s1,s2はNameがnull
            s1.Hello();
            s2.Hello();
            n.Hello();

            // Nameに値を代入
            s1.Name = "s1";
            s2.Name = "s2";

            // Helloメソッドの内容を表示
            s1.Hello();
            s2.Hello();
            n.Hello();

            // step2
            Console.WriteLine("\n-Step2-");

            var s1_2 = Singleton1.GetInstance(); // Singleton1クラスのインスタンス取得
            var s2_2 = Singleton2.GetInstance(); // Singleton2クラスのインスタンス取得
            var n2 = new Normal("piza");

            // Helloメソッドの内容を表示
            // s1_2,s2_2はインスタンスを使いまわしているのでs1,s2を表示
            s1.Hello();
            s2.Hello();
            n.Hello();
        }
    }
}
