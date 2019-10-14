using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.Singleton
{
    /// <summary>
    /// API統一用インターフェース
    /// </summary>
    public interface IAPI
    {
        /// <summary>
        /// インターフェースはstaticメソッドをもてない
        /// </summary>
        /// <returns></returns>
        //static ISingleton GetInstance();

        /// <summary>
        /// コンソールにメッセージを表示するメソッド
        /// </summary>
        void Hello();

        /// <summary>
        /// 名前に関するプロパティ
        /// </summary>
        string Name { get; set; }
    }
}