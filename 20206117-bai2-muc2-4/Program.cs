using System;

namespace _20206117_Bai2_Muc2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lan luot nhap vao 2 so a,b muon tim UCLN va BCNN: ");
            int a, b;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            int _a = a, _b = b;
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("BCNN cua a va b la: {0}", a);
            Console.WriteLine("UCLN cua a va b la: {0}", _a * _b / a);
        }
    }
}