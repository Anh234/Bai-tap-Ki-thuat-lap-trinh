using System;
using System.IO;

namespace _20206117_Bai2_Muc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hay nhap dia chi cua file: ");
            string path = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("Khong tim thay file. Mac dinh io.txt tai thu muc goc.");
                path = @"io.txt";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
            }
            Console.WriteLine("Nhap vao mot so de chon che do xu ly file: ");
            Console.WriteLine("1: Doc file\n2: Viet de len file\n3: Viet them vao file\n");
            while (true)
            {
                int i; Int32.TryParse(Console.ReadLine(), out i);
                switch (i)
                {
                    case 1:
                        ShowFile(path);
                        break;
                    case 2:
                        WriteOnFile(path);
                        break;
                    default:
                        AppendFile(path);
                        goto BREAK;
                }
            BREAK: break;
            }
        }
        static void AppendFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                throw new Exception("ERROR: FILE NOT FOUND!");
            }
            Console.WriteLine("To stop writing, type \" \\s \" ");
            using (StreamWriter sw = new StreamWriter(path, append: true))
            {
                string s; int i = 0;
                s = Console.ReadLine();
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "\\s")
                    {
                        break;
                    }
                    sw.WriteLine(s);
                }
            }
        }

        static void WriteOnFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                throw new Exception("ERROR: FILE NOT FOUND!");
            }
            Console.WriteLine("To stop writing, type \" \\s \" ");
            using (StreamWriter sw = new StreamWriter(path, append: false))
            {
                string s; int i = 0;
                s = Console.ReadLine();
                while (true)
                {
                    if (s == "\\s")
                    {
                        break;
                    }
                    sw.WriteLine(s);
                }
            }
        }

        static void ShowFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                throw new Exception("ERROR: FILE NOT FOUND!");
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s; int i = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    i++;
                    Console.WriteLine("{0}:      " + s, i);
                }
            }
        }
    }
}
