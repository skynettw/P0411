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
            int n;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}!={1}",
                n, 
                Factorial(n)
                );
        }
        
        // 產生費氏數列的函數 
        static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Prog2()
        {
            int n;
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=n; i++) {
                Console.Write("{0} ",Fib(i));
            }
            Console.WriteLine();
            
        }

        static void Prog3()
        {
            Car a = new Car("Toyota", "Vios", "Red");
            Car b = new Car("BMW", "Z4", "Yellow");
            a.ShowMe();
            b.ShowMe();
            a.Color="White";
            a.ShowMe();
        }
        static void Main(string[] args)
        {
            Prog3();    
            Console.ReadKey();
        }
    }
}
