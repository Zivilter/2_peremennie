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
            Console.ReadKey();

            //Операция упаковки провелась 1 раз [object p3=p1], и операция распаковки - тоже 1 раз [(int)p3]
        }
    }
}
