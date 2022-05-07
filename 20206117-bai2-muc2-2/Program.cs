//Pham Ngoc Anh - 20206117

using System;

namespace _20206117_Bai2_Muc2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Nhap vao so nguyen can xet: ");
                int n; bool flag = true; string s;
                s = Console.ReadLine();
                if (s == "\\s") goto BREAK;
                while (!Int32.TryParse(s, out n))
                {
                    Console.WriteLine("Du lieu nhap vao khong dung, nhap lai: ");
                };
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (n == 0 || n == 1)
                {
                    flag = false;
                }
                string output = flag ? "{0} la mot so nguyen to." : "{0} khong phai la mot so nguyen to.";
                Console.WriteLine(output, n);
                Console.ReadLine();
            }
        BREAK: return;
        }
    }
}