using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncPrintHelloWorld();
            Console.ReadLine();
        }




        public async static void AsyncPrintHelloWorld()
        {
            Console.WriteLine("异步方法调用开始"+DateTime.Now.ToString());
            var result1 = TMothd1(9);
            var result2 = TMothd2();
            var result3 = TMothd3();
            Console.WriteLine("异步方法完成" + DateTime.Now.ToString());
            int r1 = await result1;
            int r2 = await result2;
            Console.WriteLine("{0},{1},{2}", r1, r2, DateTime.Now.ToString());

            int r3 = await result3;

            Console.WriteLine("{0},{1}", r3, DateTime.Now.ToString());
        }

        public async static Task<int> TMothd1(int a)
        {
            return await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5 * 1000);
                Console.WriteLine("TMothd1 完成" + DateTime.Now.ToString());
                return 1+a;
            });
        }

        public async static Task<int> TMothd2()
        {
            return await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(10 * 1000);
                Console.WriteLine("TMothd2 完成" + DateTime.Now.ToString());
                return 2;
            });
        }
        public async static Task<int> TMothd3()
        {
            return await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(15 * 1000);
                Console.WriteLine("TMothd3 完成" + DateTime.Now.ToString());
                return 3;
            });
        }



    }
}
