using System.ComponentModel.Design;

namespace _1dan100gacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int son;
            Console.Write("sonni kiriting(1 ... 99999) --> ");
            son = int.Parse(Console.ReadLine());
            switch (son / 10000)
            {
                case 0:
                    goto Ha; break;
                case 1:
                    Console.Write("o`n "); break;
                case 2:
                    Console.Write("yigirma "); break;
                case 3:
                    Console.Write("o`ttiz "); break;
                case 4:
                    Console.Write("qirq "); break;
                case 5:
                    Console.Write("ellik "); break;
                case 6:
                    Console.Write("oltmish "); break;
                case 7:
                    Console.Write("yetmish "); break;
                case 8:
                    Console.Write("sakson "); break;
                case 9:
                    Console.Write("to`qson "); break;
            }
        Ha:
            switch ((son / 1000) % 10)
            {
                case 0:
                    if (son / 10000 != 0) Console.Write("ming ");
                    else Console.Write(""); break;
                case 1:
                    Console.Write("bir ming "); break;
                case 2:
                    Console.Write("ikki ming "); break;
                case 3:
                    Console.Write("uch ming "); break;
                case 4:
                    Console.Write("to`rt ming "); break;
                case 5:
                    Console.Write("besh ming "); break;
                case 6:
                    Console.Write("olti ming "); break;
                case 7:
                    Console.Write("yetti ming "); break;
                case 8:
                    Console.Write("sakkiz ming "); break;
                case 9:
                    Console.Write("to`qqiz ming "); break;
            }
        Ha1:
            switch (son / 100 % 10)
            {
                case 0:
                    goto Ha3; break;
                case 1:
                    Console.Write("bir yuz "); break;
                case 2:
                    Console.Write("ikki yuz "); break;
                case 3:
                    Console.Write("uch yuz "); break;
                case 4:
                    Console.Write("to`rt yuz "); break;
                case 5:
                    Console.Write("besh yuz "); break;
                case 6:
                    Console.Write("olti yuz "); break;
                case 7:
                    Console.Write("yetti yuz "); break;
                case 8:
                    Console.Write("sakkiz yuz "); break;
                case 9:
                    Console.Write("to`qqiz yuz "); break;
            }
        Ha3:
            switch (son / 10 % 10)
            {
                case 1:
                    Console.Write("on "); break;
                case 2:
                    Console.Write("yigirma "); break;
                case 3:
                    Console.Write("o`ttiz "); break;
                case 4:
                    Console.Write("qirq "); break;
                case 5:
                    Console.Write("ellik "); break;
                case 6:
                    Console.Write("Oltmish "); break;
                case 7:
                    Console.Write("yetmish "); break;
                case 8:
                    Console.Write("sakson "); break;
                case 9:
                    Console.Write("to`qson "); break;
            }
        Ha4:
            switch (son % 10)
            {
                case 0:
                    Console.WriteLine(""); ; break;
                case 1:
                    Console.Write("bir "); break;
                case 2:
                    Console.Write("ikki "); break;
                case 3:
                    Console.Write("uch "); break;
                case 4:
                    Console.Write("to`rt "); break;
                case 5:
                    Console.Write("besh "); break;
                case 6:
                    Console.Write("olti "); break;
                case 7:
                    Console.Write("yetti "); break;
                case 8:
                    Console.Write("sakkiz "); break;
                case 9:
                    Console.Write("to`qqiz "); break;
                    Console.WriteLine("        ");
            }
        }
    }
}