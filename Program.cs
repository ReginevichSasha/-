using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //1
            int per = 1;
            float per2 = 1;
            char per3 = 'h';
            string per4 = "hello";
            bool per5 = true;
            long per7 = 1;
            byte per8 = 1;
            double per9 = 1;
            short per10 = 1;
            //1-2
            per7 += per8;
            per += per8;
            per2 += per;
            per9 += per;
            per10 += per8;
            //явное
            per += (int)per2;
            per7 += (long)per3;
            per9 += (double)per8;
            per2 += (float)per9;
            per3 += (char)per8;
            //1-3
            {
                object obj = per;//упаковка значения переменной в объект
                int x = (int)obj;// распаковать значение и объекта, доступного по ссылке obj,в переменную типа int
                Console.WriteLine(x);
            }
            //1-4
            {
                var name = "Sasha";
                Type nameType = name.GetType();
                Console.WriteLine("Тип name: {0}", nameType);
            }
            //1-5
            {
                int? a = null, b = 3, c = 6;
                Console.WriteLine(a ?? b ?? c);
                int? x = null;
                int y = x ?? 10;
                Console.WriteLine(y);
            }
            //2
            string str1 = "pupsik";
            string str2 = "pups";
            int resultat = String.Compare(str1, str2);
            Console.WriteLine("Результат сравнения строк:" + resultat);//положительное,ecли str1>str2
            string str3 = "pups";
            string str4 = "pups";
            int resultat2 = String.Compare(str3, str4);
            Console.WriteLine("Результат сравнения строк:" + resultat2);//строки равны
            //2-2
            string str5 = "первая строка+";
            string str6 = "вторая строка";
            string str7 = " маленький пончик ";
            string sceplenie = String.Concat(str5, str6);
            Console.WriteLine("Результат сцепления -", sceplenie);
            string podstroka = str7.Substring(6);
            Console.WriteLine("Подстрока -" + podstroka);
            string str8 = String.Copy(str5);
            Console.WriteLine("Копия строки:  " + str7);
            string razdelenie = " очень мальнький пончик";
            string[] words = razdelenie.Split(' ');
            Console.WriteLine("Разделенная строка:  ");
            foreach (string word in words)//для отображения массива разделение
            {
                Console.WriteLine(word);
            }
            str5 = str5.Insert(7, str7);
            Console.WriteLine("Вставки подстроки в заданную позицию:" + str5);
            razdelenie = razdelenie.Remove(6);
            Console.WriteLine("Новая строка: " + razdelenie);
            //2-3
            string pusto = "";
            string nulstr = null;
            int len = pusto.Length;
            Console.WriteLine("Длина пустой строки: " + len);
            //2-4
            StringBuilder str9 = new StringBuilder("ponchik", 25);
            Console.WriteLine(str9);
            str9.Append("POP");//добавляем в конец строки символы
            Console.WriteLine(str9);
            str9.Remove(1, 5);
            Console.WriteLine(str9);
            //3-1
            int[,] arrey1 = new int[3, 3] { { 1, 2, 4 }, { 3, 4, 5 }, { 0, 2, 5 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrey1[i, j] + "  ");
                }
                Console.Write("\n");
            }
            //3-2
            int[] arrey2 = new int[] { 1, 6, 5, 4, 8 };
            int arrlen = arrey2.Length;
            Console.WriteLine("Длина массива " + arrlen + " символа:");
            foreach (int x in arrey2)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine("\nВведите индекс элемента, который хотите изменить:");
            int in1 = Convert.ToInt32(Console.ReadLine());
            string[] arrey3 = new string[] { "raz", "dva", "tri" };//меняем произвольный элемент
            Console.WriteLine("Введите значение:");
            string in2 = Console.ReadLine();
            arrey3[in1] = in2;
            Console.WriteLine("Измененный массив строк длиной " + arrlen + " символа:");
            foreach (string x in arrey3)
            {
                Console.Write(x + "   ");
            }
            //3-3
            int[][] arrey4 = new int[3][];
            arrey4[0] = new int[2];
            arrey4[1] = new int[3];
            arrey4[2] = new int[4];
            for (int x = 0; x < 3; x++)
            {
                arrey4[0][x] = x;
                for (int y = 0; y < arrey4[x].Length; y++)
                {
                    Console.WriteLine("Введите элемент массива: ");
                    arrey4[x][y] = Convert.ToInt32(Console.ReadLine());
                }
                for (x = 0; x < 3; x++)
                {
                    for (int y = 0; y < arrey4[x].Length; y++)
                    {
                        Console.Write(arrey4[x][y] + "  ");

                    }
                    Console.Write("\n");
                }
                //3-4
                int[] aar = new int[] { 1, 3 };//неявно типизированные переменные для хранения массива и строки.
                var peremen = aar;
                String peremen2 = "bla bla";
                var strvar = peremen2;
                //4-1
                var korteg = Tuple.Create(per, per4, per3, per4, per7);
                Console.WriteLine(korteg);
                Console.WriteLine(korteg.Item1);
                Console.WriteLine(korteg.Item3);
                Console.WriteLine(korteg.Item4);
                char ttt = (char)korteg.Item3;//распаковка
                int t = 1, t2 = 2, t3 = 3, t4 = 5, t5 = 8, t6 = 9; ;
                var korteg2 = Tuple.Create(t, t2, t3);
                var korteg3 = Tuple.Create(t4, t5, t6);
                if (korteg2 == korteg3)
                {
                    Console.WriteLine("Кортежи равны");
                }
                else
                {
                    Console.WriteLine("Кортежи не равны");
                }

            }

        }
            static Tuple<int,int,int,char> bla(string h,int[]b)
        {
            int min = 0, max = 0, sum = 0;char d;
            foreach( int t in b)
            {
                if (t > max) { max = t; }
                if (t < min){ min = t; }
                sum += t;               

            }
            d = h[0];
            var s = Tuple.Create<int, int, int, char>(min, max, sum, d);
            return s;

        }
    }
}
