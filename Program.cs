using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 调用回调函数
{
    class Program
    {
        public delegate int delTemp(int x);

        static void Main(string[] args)
        {
            delTemp dt = Temp1;
            Console.WriteLine(Calculate(2, dt));

            delTemp dt2 = Class1.AddTemp;
            Console.WriteLine(Calculate(3,dt2));
        }

        /// <summary>
        /// 此处直接将Temp1作为Calculate的参数将报错，C#为强类型，则一定要用委托做中转（方法作为参数 类似C的函数指针）
        /// </summary>
        /// <param name="a"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static int Calculate(int a,delTemp X)
        {
            return X(a);
            
        }

        public static int Temp1(int a)
        {
            return a * 2;
        }
    }
}
