using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.Singleton
{
    /// <summary>
    /// シングルトンパターン
    /// 遅延初期化のパターン
    /// </summary>
    public class Singleton2 : IAPI
    {
        /// <summary>
        /// 変数宣言時はnull
        /// </summary>
        private static Singleton2 _singleton2;

        /// <summary>
        /// Instanceメソッドが呼ばれたときに、変数がnullなら初期化したものを代入
        /// </summary>
        /// <returns></returns>
        public static Singleton2 GetInstance() => _singleton2 ?? (_singleton2 = new Singleton2());

        /// <summary>
        /// プロパティの場合はGetで取得する
        /// </summary>
        //public static Singleton2 Instance
        //{
        //    get { return _singleton2 ?? (_singleton2 = new Singleton2()); }
        //}

        private Singleton2()
        { }

        /// <summary>
        /// hugehugeいうだけのメソッド
        /// </summary>
        public void Hello() => Console.WriteLine($"hugehuge : {Name}");

        /// <summary>
        /// 文字列をSet・Getするプロパティ
        /// </summary>
        public string Name { get; set; }
    }
}