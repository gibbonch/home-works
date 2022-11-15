using System;

namespace Triangle
{
    class Program
    {
        public static double Max(double a, double b, double c)//находит максимум из трех элементов
        {
            double max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }

        static void Main(string[] args)
        {

            //треугольники могут иметь вид:

            // *
            // **
            // ***
            // ****

            //    *
            //   ***
            //  *****
            // *******

            //   *
            //  **
            // ***
            //****
            // ***
            //  **
            //   *

            // ...

            double x1, y1, x2, y2, x3, y3;

            while (true)
            {
                /*______________ввод данных___________________________________*/

                Console.Write("input x1 y1 >> ");
                string[] num1 = Console.ReadLine().Split(' ');
                x1 = double.Parse(num1[0]);
                y1 = double.Parse(num1[1]);

                Console.Write("input x2 y2 >> ");
                string[] num2 = Console.ReadLine().Split(' ');
                x2 = int.Parse(num2[0]);
                y2 = int.Parse(num2[1]);

                Console.Write("input x3 y3 >> ");
                string[] num3 = Console.ReadLine().Split(' ');
                x3 = int.Parse(num3[0]);
                y3 = int.Parse(num3[1]);
                /*____________________________________________________________*/

                // проверка корректности ввода
                // из точки 1 рассматриваем все возможные прямые и если обнаруживается пресечение с двумя точками, то данные корректны
                // важно исключить случаи, когда все 3 точки на одной прямой

                int k = 0; // счетчк пересеченинй

                string s = ""; // дает информацию на каких прямых были пересечения

                double m_x = Max(x1, x2, x3);
                double m_y = Max(y1, y2, y3);

                double x1_nw = x1;
                double y1_nw = y1;

                double x1_n = x1;
                double y1_n = y1;

                double x1_ne = x1;
                double y1_ne = y1;

                double x1_e = x1;
                double y1_e = y1;

                double x1_se = x1;
                double y1_se = y1;

                double x1_s = x1;
                double y1_s = y1;

                double x1_sw = x1;
                double y1_sw = y1;

                double x1_w = x1;
                double y1_w = y1;

                /*___________проверка корректности ввода______________________*/

                while (x1_nw != 0 && y1_nw != 0)
                {
                    x1_nw--;
                    y1_nw--;
                    if (x1_nw == x2 && y1_nw == y2 || x1_nw == x3 && y1_nw == y3)
                    {
                        k++;
                        s += "a";
                        break;
                    }
                }

                while (y1_n != 0)
                {
                    y1_n--;
                    if (x1_n == x2 && y1_n == y2 || x1_n == x3 && y1_n == y3)
                    {
                        k++;
                        s += "b";
                        break;
                    }
                }

                while (x1_ne != m_x && y1_ne != 0)
                {
                    x1_ne++;
                    y1_ne--;
                    if (x1_ne == x2 && y1_ne == y2 || x1_ne == x3 && y1_ne == y3)
                    {
                        k++;
                        s += "c";
                        break;
                    }
                }

                while (x1_e != m_x)
                {
                    x1_e++;
                    if (x1_e == x2 && y1_e == y2 || x1_e == x3 && y1_e == y3)
                    {
                        k++;
                        s += "d";
                        break;
                    }
                }

                while (x1_se != m_x && y1_se != m_y)
                {
                    x1_se++;
                    y1_se++;
                    if (x1_se == x2 && y1_se == y2 || x1_se == x3 && y1_se == y3)
                    {
                        k++;
                        s += "a";
                        break;
                    }
                }

                while (y1_s != m_y)
                {
                    y1_s++;
                    if (x1_s == x2 && y1_s == y2 || x1_s == x3 && y1_s == y3)
                    {
                        k++;
                        s += "b";
                        break;
                    }
                }

                while (x1_sw != 0 && y1_sw != m_y)
                {
                    x1_sw--;
                    y1_sw++;
                    if (x1_sw == x2 && y1_sw == y2 || x1_sw == x3 && y1_sw == y3)
                    {
                        k++;
                        s += "c";
                        break;
                    }
                }

                while (x1_w != 0)
                {
                    x1_w--;
                    if (x1_w == x2 && y1_w == y2 || x1_w == x3 && y1_w == y3)
                    {
                        k++;
                        s += "d";
                        break;
                    }
                }

                //aa, bb, cc, dd означает что координаты находятся на одной прямой

                if (k == 2 && s != "aa" && s != "bb" && s != "cc" && s != "dd")
                {
                    Console.WriteLine("\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"\nERROR. IMPOSSIBLE TO CREATE A TRIANGLE \n");
                }
                /*____________________________________________________________*/

            }

            // ставим * на границе треугольника и если пересекли границу один раз, но это не вершина,
            // или если вершина, то в предыдущей строке было несколько звездочек

            double max_x = Max(x1, x2, x3);
            double max_y = Max(y1, y2, y3);
            int ls = 0;

            for (int i = 0; i <= max_y; i++)
            {
                int counter = 0;
                int last_s = 0;
                for (int j = 0; j <= max_x; j++)
                {
                    if (j == x1 && i == y1 || j == x2 && i == y2 || j == x3 && i == y3)
                    {
                        if (i != max_y && ls > 0)
                        {
                            counter++;
                        }
                        Console.Write("*");
                        continue;
                    }
                    if (x1 == x2 && j == x1 && (i <= y1 && i >= y2 || i >= y1 && i <= y2))
                    {
                        counter++;
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    if (x1 == x3 && j == x1 && (i <= y1 && i >= y3 || i >= y1 && i <= y3))
                    {
                        counter++;
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    if (x3 == x2 && j == x3 && (i <= y3 && i >= y2 || i >= y3 && i <= y2))
                    {
                        counter++;
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    if (y1 == y2 && i == y1 && (j <= x1 && j >= x2 || j >= x1 && j <= x2))
                    {
                        Console.Write("*");
                        last_s++;
                        continue;
                    }

                    if (y1 == y3 && i == y1 && (j <= x1 && j >= x3 || j >= x1 && j <= x3))
                    {
                        Console.Write("*");
                        last_s++;
                        continue;
                    }

                    if (y3 == y2 && i == y3 && (j <= x3 && j >= x2 || j >= x3 && j <= x2))
                    {
                        Console.Write("*");
                        last_s++;
                        continue;
                    }

                    if ((j - x1) / (x2 - x1) == (i - y1) / (y2 - y1) && (j >= x1 && j <= x2 || j <= x1 && j >= x2))
                    {
                        counter++;
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    if ((j - x1) / (x3 - x1) == (i - y1) / (y3 - y1) && (j >= x1 && j <= x3 || j <= x1 && j >= x3))
                    {
                        counter++;
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    if ((j - x3) / (x2 - x3) == (i - y3) / (y2 - y3) && (j >= x3 && j <= x2 || j <= x3 && j >= x2))
                    {
                        counter++;
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    if (counter == 1)
                    {
                        last_s++;
                        Console.Write("*");
                        continue;
                    }

                    Console.Write(" ");
                }
                ls = last_s;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}