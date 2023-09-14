using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule2
{
    internal class Program
    {
        static void Exmpl02()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
            Console.ReadKey();
        }
        static void Exmpl07()
        {
            Console.Write("Введите радиус круга:");
            int  a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите сторону квадрата:");
            int b = Convert.ToInt32(Console.ReadLine());

            double p= 3.14;
            double PloshadKruga = a * a * p;
            int PloshadKvadrata = b * b;



            if (PloshadKruga > PloshadKvadrata)
            {
                Console.WriteLine(PloshadKruga);
            }
            else
            {
                Console.WriteLine(PloshadKvadrata);
            }
            Console.ReadKey();
        }
        static void Exmpl10()
        {
            //a
            Console.WriteLine("a) Все целые числа от 20 до 35 ");
            for (int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
                 
            }
            //b
            Console.WriteLine("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"b)Квадраты всех целых чисел от 10 до {a} : ");
            if (a > 10)
            {
                for (int j = 0; j+10 < a; j++)
                {
                    int b = (10+j) * (10 + j);
                    Console.WriteLine($"{b}");
                }
            }
            else {
                Console.WriteLine( $"{a} меньше 10");
            }
            //c
            Console.WriteLine("Введите число :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"с)Третья степень всех целых чисел от {a} до 50 :");
            if (a < 50)
            {
                for (int j = 0; j + a < 50; j++)
                {
                    int b = ( a + j ) * ( a + j) * (a + j);
                    Console.WriteLine($"{b}");
                }
            }
            else
            {
                Console.WriteLine($"{a} больше 50");
            }
            //d
            Console.WriteLine("Введите число a :");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b :");
            int d2 = Convert.ToInt32(Console.ReadLine());
                     if (d1 > d2)
            {
                Console.WriteLine($"d)Все целые числа от {d2} до {d1} :");
                for (int j = d2; j < d1+1; j++)
                {
                    Console.WriteLine($"{j}");
                }
            }
            else {
                Console.WriteLine($"d)Все целые числа от {d1} до {d2} :");
                for (int j = d1; j < d2+1; j++)
                {
                    Console.WriteLine($"{j}");
                }
            }
            Console.ReadKey(true);

        }
        static void Exmpl30()
        {
            Console.Write("Введите 1 число :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите  2 число :");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }

                }
                Console.WriteLine($"Cумма всех нечетных целых чисел в пределах от {a} до {b} : {sum}");
            }
            else {
                for (int i = b; i <= a; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }

                }
                Console.WriteLine($"Cумма всех нечетных целых чисел в пределах от {b} до {a} : {sum}");
            }
            Console.ReadKey(false);

        }

        static void Exmpl15()
        {
            Console.Write("Введите число :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 10;
            int c = a % 10;
            int sum = b + c;
            int proizvedenie = b * c;
            Console.WriteLine($"a. число десятков в нем {b};\r\n\r\nb. число единиц в нем {c};\r\n\r\nc. суммa его цифр {sum};\r\n\r\nd. произведение его цифр {proizvedenie}");

            Console.ReadKey(true);
        }

        static void Exmpl16()
        {
            Console.Write("Введите 4 значное число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 1000)
            {
                int b = a / 1000;
                int c = (a - b * 1000) / 100;
                int d = ((a % 1000) % 100) / 10;
                int e = ((a % 1000) % 100) % 10;
                int sum = b + c + d + e;
                int proizvedenie = b * c * d * e;
                Console.WriteLine("Сумма цифр " + sum);
                Console.WriteLine("Произведение цифр " + proizvedenie);
            }
            else {
                Console.WriteLine("Значение не четырехзначное");
            }
            Console.ReadKey();

        }
        static void Exmpl03()
        {
            Console.WriteLine("Введите величину в см");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} cm = " + a / 100 + "m");

            Console.ReadKey();
        }
        static void Exmpl13()
        {
            Console.WriteLine("Введите величину в см");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} cm = " + a / 100 + "m");

            Console.ReadKey();
        }
        static void Exmpl23()
        {
            Console.WriteLine("Введите часы");
            double h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            double s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Количество секунд, прошедших с начала дня: " + h * 3600 + m * 60 + s);
            Console.ReadKey(true);

        }
        static void Exmpl24()
        {
            Console.WriteLine("Введите месяц");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            double d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(m * 30 + d);
            Console.ReadKey(true);

        }
        static void Exmpl25()
        {
            Console.WriteLine("Введите месяц");
            double m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день");
            double d = Convert.ToInt32(Console.ReadLine());
            int days = 0;
            for (int i = 1; i <= m; i++)
            {
                if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    days += 30;
                }
                else days += 31;



            }
            Console.WriteLine("Kоличество дней, прошедших с начала года:" + days + d);
            Console.ReadKey(true);


        }
       



        static void Main(string[] args)
        {
            Exmpl16();
            //Кто прочитал тот Евгений Герцен Александрович
        }

    }
}