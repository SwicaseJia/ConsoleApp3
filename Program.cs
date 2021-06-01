using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /// <summary>
        /// 主函数注释
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            System.Console.WriteLine("名字");
            Console.WriteLine((new Class1()).GetName());

            System.Console.WriteLine("年龄");
            Console.WriteLine(GetAge());
            Console.ReadLine();
            Class1 cla = new Class1();
            cla.GetName();
        }
        static int GetAge()
        {
            return 1;

        }
        static int GetHeight()
        {
            return 1;

        }
        static int GetMoney()
        {
            return 1;

        }
         static int GetMoney_Branch()
        {
            string str = "在主分支上添加";
            return 1;

        }
    }
}
