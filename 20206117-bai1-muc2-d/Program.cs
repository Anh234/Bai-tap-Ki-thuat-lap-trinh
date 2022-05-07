//Pham Ngoc Anh - 20206117

using System;

namespace _20206117_Bai1_Muc2_d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao chieu cao cua cay thong Noel");
            int n;
            while (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("So da nhap vao khong hop le, nhap lai: ");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                    Console.Write(' ');
                Console.Write('*');
                for (int k = 0; k < 2 * i; k++)
                    Console.Write('*');
                Console.WriteLine();
            }
            for (int j = 0; j < n; j++)
                Console.Write(' ');
            Console.Write('|');
            Console.Read();
        }
    }
}