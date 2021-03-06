﻿using System; //используем пространство имен System

namespace Peremennyie
{
    class Program 
    {
        static void Main(string[] args)
        {
            int p1 = 50; // 1 значимая целочисленная переменная

            char p2;//2 значимая символьная переменная
            p2 = '9';

            object p3=p1; //3 переменная ссылочного типа

            double p4 =(double) 11 / 5;//4 значимая переменная с плавающей точкей

            bool p5 = default(bool); //5 переменная значимого типа


            int a, b, c;
            bool d;
            long g;

            a = (int) p3; // явное преобразование типа
            b = p2; // неявное преобразоваие типа
            c = (int) p4; // явное преобразование типа
            d = p5; // преобразования типа нет
            g = p1; //неявное преобразование типа

            // a = p3; // ошибка при компиляции. Требуется явное преобразование типов 

            //long h = 3698254170;
            //c = (int) h; // ошибка при выполнении программы в следствии переполнения типа.
            //или 
            //double h;
            //h=(double)p3; // Ошибка во время выполнения программы. Правильное написание: h=(double)(int)p3
           
            //выражение x=p4*(p1+3.14)-p3
            double x;
            x = p4 * ((double)p1 + 3.14) - (double)(int)p3;
            Console.WriteLine("{0}*({1}+3.14)-{2}={3}", p4, p1, p3, x);
            
            //Операция упаковки провелась 1 раз [object p3=p1], и операция распаковки - тоже 1 раз [(int)p3]

            //программа для конвертации массива байт в целое число
            Console.WriteLine("Программа для конвертации массива байт в целое число");
            byte[] m = {0,0,0,1,1};
            if (BitConverter.IsLittleEndian)
                Array.Reverse(m);
            int n = BitConverter.ToInt32(m, 0);
            Console.WriteLine("Преобразованное число: {0}", n);

            //конвертация строки в число
            Console.WriteLine("Конвертация строки в число");
            string s;
            s = "1598";
            long y;
            if (long.TryParse(s, out y))
                Console.WriteLine("Строка {0} конвертируется в число {1}", s, y);
            else Console.WriteLine("Введено не число");

            //конвертация символа в шестнадцетиричное и целое число
            string s2="Hello";
            Console.WriteLine("Входная строка {0}",s2);
            int n2 = s2.Length;
            byte z;
            string h;
            for(int i=0;i<n2;i++)
            {
                z = Convert.ToByte(s2[i]);
                h = z.ToString("X");
                Console.WriteLine("Символ {0}: шестнадцетиричное чило:{1}, целое число: {2}",s2[i],h,z);
            }
            
                   


            Console.ReadKey();

        }
    }
}
