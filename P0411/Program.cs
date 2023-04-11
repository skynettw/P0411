using System;

namespace P0411
{
    class Program
    {

        // 使用遞迴來設計階乘函數
        static int Factorial(int n)
        {
            if (n == 1) return 1;   // 停止自我呼叫的條件
            return n * Factorial(n - 1);
        }
        static void Prog1()
        {
            Console.WriteLine("10!={0}",
                Factorial(10)
                );
        }

        static void Main(string[] args)
        {
            Prog1();    
            Console.ReadKey();
        }
    }
}
