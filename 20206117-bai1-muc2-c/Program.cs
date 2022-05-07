//Pham Ngoc Anh - 20206117

using System;
using System.Numerics;

namespace _20206117_Bai1_Muc2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong trinh bac 2: ax^2 + bx + c = 0");
            Complex a, b, c;
            double a_real, a_img, b_real, b_img, c_real, c_img;
            Console.WriteLine("Nhap vao phan thuc cua a: ");
            while (!double.TryParse(Console.ReadLine(), out a_real))
            {
                Console.WriteLine("So nhap vao khong dung, nhap lai: ");
            }
            Console.WriteLine("Nhap vao phan ao cua a: ");
            while (!double.TryParse(Console.ReadLine(), out a_img))
            {
                Console.WriteLine("So nhap vao khong dung, nhap lai: ");
            }
            Console.WriteLine("Nhap vao phan thuc cua b: ");
            while (!double.TryParse(Console.ReadLine(), out b_real))
            {
                Console.WriteLine("So nhap vao khong dung, nhap lai: ");
            }
            Console.WriteLine("Nhap vao phan ao cua b: ");
            while (!double.TryParse(Console.ReadLine(), out b_img))
            {
                Console.WriteLine("So nhap vao khong dung, nhap lai: ");
            }
            Console.WriteLine("Nhap vao phan thuc cua c: ");
            while (!double.TryParse(Console.ReadLine(), out c_real))
            {
                Console.WriteLine("So nhap vao khong dung, nhap lai: ");
            }
            Console.WriteLine("Nhap vao phan ao cua c: ");
            while (!double.TryParse(Console.ReadLine(), out c_img))
            {
                Console.WriteLine("So nhap vao khong dung, nhap lai: ");
            }
            a = new Complex(a_real, a_img);
            b = new Complex(b_real, b_img);
            c = new Complex(c_real, c_img);
            Complex delta = b * b - 4 * a * c;
            Complex sqrtDel = Complex.Sqrt(delta);
            Complex x1 = (-b + sqrtDel) / (2 * a);
            Complex x2 = (-b - sqrtDel) / (2 * a);
            if (delta == 0)
            {
                if (sqrtDel.Imaginary == 0)
                {
                    Console.WriteLine("Root: {0}", x1.Real);
                    return;
                }
                Console.WriteLine("Root: {0}", x1);
                return;
            }
            if (sqrtDel.Imaginary == 0)
            {
                Console.WriteLine("Root 1: {0}", x1.Real);
                Console.WriteLine("Root 2: {0}", x2.Real);
                return;
            }
            Console.WriteLine("Root 1: {0}", x1);
            Console.WriteLine("Root 2: {0}", x2);
            Console.ReadLine();
            return;
        }
    }
}