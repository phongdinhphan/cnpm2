using System;

namespace BUOI1
{
    class Program
    {
        static float DTB(float a,float b)
        {
            float tb = (a + b) / 2;
            return tb;
        }
        static int GiaiThua(int n)
        {

            int giaithua = 1;
            for (int i = 0; i <= n; i++)
            {
                giaithua *=i;
                i++;
            }
            return giaithua;
        }
        static void Main(string[] args)
        {
            //cau1
            float a=5;
            float b=4;
            float tb = (a + b) / 2;
            Console.WriteLine("dtb:{0}", tb);
            Console.ReadLine();
            float TrungBinh;
             TrungBinh = DTB(a,b);
            if (tb < 5)
            {
                Console.WriteLine("rot");

            }
            else if (tb > 5 && tb < 8)
            {
                Console.WriteLine("Khá");
            }
            else
            {
                Console.WriteLine("giỏi");
            }
            //caau 2
                Console.WriteLine("nhap vào giá trị a: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("nhap vào giá trị b: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("yeu cau nhap phep toan: ");
                 char  pt = Console.ReadLine()[0];
            switch (pt)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    if (b <= 0)
                    {
                        Console.WriteLine("khong chia duoc");
                    }
                    else
                        Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;

            }
            //bai3
            int d;
            Console.WriteLine("nhap so can tinh giathua: ");
            d = int.Parse(Console.ReadLine());
            int kqgt;
            kqgt = GiaiThua(d);
            Console.WriteLine("gia thua cua so vua nhap la {0}:", kqgt);
            Console.ReadLine();





        }

        }
    }
