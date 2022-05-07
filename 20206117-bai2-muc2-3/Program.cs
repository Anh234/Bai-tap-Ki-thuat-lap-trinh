//Pham Ngoc Anh - 20206117

using System;
using System.Collections.Generic;

namespace _20206117_Bai2_Muc2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ban muon tu mieu ta cay hay chon mot tuy chon san co?\nNhap 1 de mieu ta, Nhap 2 de tuy chon san co: ");
            int n;
            while (!Int32.TryParse(Console.ReadLine(), out n) || (n != 1 && n != 2))
            {
                Console.WriteLine("So lieu nhap vao khong dung, nhap lai: ");
            }
            switch (n)
            {
                case 1:
                    Console.WriteLine("Ban muon co bao nhieu patterns cho cay cua minh? ");
                    int patNum;
                    while (!Int32.TryParse(Console.ReadLine(), out patNum))
                    {
                        Console.WriteLine("So lieu nhap vao khong dung, nhap lai: ");
                    }
                    string[] lines = new string[patNum]; List<char>[] patterns = new List<char>[patNum];
                    Console.WriteLine("Ban hay mieu ta cay cua minh :");
                    for (int i = 0; i < patNum; i++)
                    {
                        Console.WriteLine("Nhap vao patterns {0}: ", i + 1);
                        lines[i] = Console.ReadLine(); patterns[i] = new List<char>();
                        for (int j = 0; j < lines[i].Length; j++)
                        {
                            patterns[i].Add(lines[i][j]);
                        }
                    }
                    Console.WriteLine("Nhap chieu cao cua cay: ");
                    int height;
                    while (!Int32.TryParse(Console.ReadLine(), out height))
                    {
                        Console.WriteLine("So lieu nhap vao khong dung, nhap lai: ");
                    }
                    Console.WriteLine("Nhap vao cach le trai: ");
                    int left;
                    while (!Int32.TryParse(Console.ReadLine(), out left))
                    {
                        Console.WriteLine("So lieu nhap vao khong dung, nhap lai: ");
                    }
                    Console.WriteLine("Nhap vao cach le phai: ");
                    int right;
                    while (!Int32.TryParse(Console.ReadLine(), out right))
                    {
                        Console.WriteLine("So lieu nhap vao khong dung, nhap lai: ");
                    }
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < (height - i) * left; j++)
                            Console.Write(' ');
                        for (int k = 0; k < 1 + (left + right) * i; k++)
                        {
                            Console.Write(patterns[i % patterns.Length][k % (patterns[i % patterns.Length]).Count]);
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Hay nhap vao mot so de chon loai cay: ");
                    Console.WriteLine("De chon cay ben trai, chon 1 \nDe chon cay ben phai, chon 2 \nDe chon cay can xung, chon 3 \nDe chon cay hinh thoi, chon 4");
                    int m;
                    while (!Int32.TryParse(Console.ReadLine(), out m))
                    {
                        Console.WriteLine("So da nhap vao khong hop le, nhap lai: ");
                    }
                    Console.WriteLine("Nhap vao chieu cao cua cay thong Noel");
                    int o;
                    while (!Int32.TryParse(Console.ReadLine(), out o))
                    {
                        Console.WriteLine("So da nhap vao khong hop le, nhap lai: ");
                    }
                    switch (m)
                    {
                        case 1:
                            for (int i = 0; i < o; i++)
                            {
                                Console.Write('*');
                                for (int k = 0; k < 2 * i; k++)
                                    Console.Write('*');
                                Console.WriteLine();
                            }
                            for (int j = 0; j < o; j++)
                                Console.Write(' ');
                            Console.Write('|');
                            Console.Read();
                            break;
                        case 2:
                            for (int i = 0; i < o; i++)
                            {
                                for (int j = 0; j < o - i; j++)
                                    Console.Write(' ');
                                Console.Write('*');
                                for (int k = 0; k < i; k++)
                                    Console.Write('*');
                                Console.WriteLine();
                            }
                            for (int j = 0; j < o; j++)
                                Console.Write(' ');
                            Console.Write('|');
                            Console.Read();
                            break;
                        case 3:
                            for (int i = 0; i < o; i++)
                            {
                                for (int j = 0; j < o - i; j++)
                                    Console.Write(' ');
                                Console.Write('*');
                                for (int k = 0; k < 2 * i; k++)
                                    Console.Write('*');
                                Console.WriteLine();
                            }
                            for (int j = 0; j < o; j++)
                                Console.Write(' ');
                            Console.Write('|');
                            Console.Read();
                            break;
                        case 4:
                            for (int i = 0; i < o; i++)
                            {
                                for (int j = 0; j < o - i; j++)
                                    Console.Write(' ');
                                Console.Write('*');
                                for (int k = 0; k < 2 * i; k++)
                                    Console.Write('*');
                                Console.WriteLine();
                            }
                            for (int j = 0; j < o; j++)
                                Console.Write(' ');
                            for (int i = o; i > 0; i--)
                            {
                                for (int j = 0; j < o - i; j++)
                                    Console.Write(' ');
                                Console.Write('*');
                                for (int k = 0; k < 2 * i; k++)
                                    Console.Write('*');
                                Console.WriteLine();
                            }
                            for (int j = 0; j < o; j++)
                                Console.Write(' ');
                            Console.Write('|');
                            Console.Read();
                            break;
                        default:
                            break;
                    }


                    break;
            }
        }
    }
}