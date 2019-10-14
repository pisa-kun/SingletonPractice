using SingletonSample.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.Class
{
    public class Normal : IAPI
    {
        /// <summary>
        /// インスタンスを生成するときにNameに値をsetする
        /// </summary>
        /// <param name="name"></param>
        public Normal(string name) => Name = name;

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public void Hello() => Console.WriteLine($"Normal : {Name}");
    }
}
