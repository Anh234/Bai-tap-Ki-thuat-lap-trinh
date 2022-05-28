//pham ngoc anh-2020117

using System;

namespace ngocanh
{
    class TestCsharp
    {
        public static void Main()
        {

            int[] arr1 = new int[100];
            int i, mx, mn, n;


            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);

            Console.ReadKey();
        }
    }
}