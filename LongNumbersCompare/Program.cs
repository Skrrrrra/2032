using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace LongNumbersCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //путь
            string inputpath = "D:\\SolutionsForSpaceApp\\2032\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2032\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            int a;
            using (var readera = new StreamReader(inputpath))
            {
                a = Convert.ToInt32(readera.ReadLine());  // записываем в переменную
            };
            //переменная для обьвления размера массива#2
            int b;
            using (var readerb = new StreamReader(inputpath))
            {
                readerb.ReadLine(); //пропуск 1 строки
                readerb.ReadLine(); //пропуск 2 строки
                b = Convert.ToInt32(readerb.ReadLine());  // записываем в переменную 3 строку
            };

            //запись в строку содержимого 2 строки файла
            string secondLine;
            using (var readersecond = new StreamReader(inputpath))
            {
                readersecond.ReadLine(); //пропуск 1 строки
                secondLine = readersecond.ReadLine();  // записываем в переменную
            }

            //запись в строку содержимого 4 строки файла
            string fourthLine;
            using (var readerfourth = new StreamReader(inputpath))
            {
                readerfourth.ReadLine(); //пропуск 1 строки
                readerfourth.ReadLine(); //пропуск 2 строки
                readerfourth.ReadLine(); //пропуск 3 строки
                fourthLine = readerfourth.ReadLine();  // записываем в переменную
            }

            string[] secondlineforint = secondLine.Split(' ');

            string[] fourthlineforint = fourthLine.Split(' ');


            //создание массивов куда будут записываться числа
            int[] A;
            A = new int[a];

            int[] B;
            B = new int[b];


            //запись элементов в А
            int count = 0;
            foreach (var s in secondlineforint)
            {
                if (count <= a)
                {
                    A[count] = Convert.ToInt32(s);
                    count++;
                }
            }

            //запись элементов в Б
            count = 0;
            foreach (var sy in fourthlineforint)
            {
                if (count <= a)
                {
                    B[count] = Convert.ToInt32(sy);
                    count++;
                }
            }
            string firstnumber = "";
            for (int i = 0; i < A.Length; i++)
            {
                firstnumber = firstnumber + A[i]; 
            }

            string secondnumber = "";
            for (int i = 0; i < B.Length; i++)
            {
                secondnumber = secondnumber + B[i];
            }

            int first = Convert.ToInt32(firstnumber);
            int second = Convert.ToInt32(secondnumber);


            using (var writer = new StreamWriter(outputpath))
            {

                if (first < second)
                {
                    writer.Write((-1).ToString()); //пропуск 1 строки
                }
                else if (first > second)
                {
                    writer.Write((1).ToString()); //пропуск 1 строки

                }
                else
                {
                    writer.Write(0.ToString()); //пропуск 1 строки
                }



            }
        }
    } 
}
