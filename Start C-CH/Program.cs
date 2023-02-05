using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Start_C_SH
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Clear();
                WriteLine("Input action - 1,2 or 3 and press Enter");
                ConsoleKey act = ReadKey().Key;
                switch (act)
                {
                    case ConsoleKey.D1:
                        {
                            Clear();
                            WriteLine("---------------------");
                            WriteLine("*ToUpper and ToLower*");
                            WriteLine("---------------------");
                            string str = "uppercase translation";
                            WriteLine(str);
                            WriteLine(str.ToUpper());
                            WriteLine("**********************");
                            string str_2 = "LOWERCASE TRANSLATION";
                            WriteLine(str_2);
                            WriteLine(str_2.ToLower());
                            WriteLine("**********************");
                            WriteLine("Press Enter");
                        }
                        break;
                    case ConsoleKey.D2:
                        {
                            Clear();
                            WriteLine("-------------------------------------------");
                            WriteLine("*Input numbers for Reverse and press Enter*");
                            WriteLine("-------------------------------------------");
                            string input = ReadLine();
                            WriteLine();
                            char[] inputarray = input.ToCharArray();
                            Array.Reverse(inputarray);
                            string output = new string(inputarray);
                            WriteLine(output);
                            WriteLine("Press Enter");

                        }
                        break;
                    case ConsoleKey.D3:
                        {
                            Clear();
                            WriteLine("--------------------------------------------------");
                            WriteLine("*Outputting a two-dimensional array to the screen*");
                            WriteLine("--------------------------------------------------");
                            int a, b, c;
                            bool res, res1;
                            do
                            {
                                WriteLine("Input number A");
                                res = int.TryParse(ReadLine(), out a);
                                WriteLine("Input number B");
                                res1 = int.TryParse(ReadLine(), out b);
                                if ((res == false) || (res1 == false))
                                {
                                    WriteLine("Input just numbers");
                                }
                                else
                                {
                                    WriteLine("Number A = " + a);
                                    WriteLine("Number B = " + b);
                                }

                            } while ((res == false) || (res1 == false));
                            c = a;
                            WriteLine("--------------------------------------------------");
                            int[][] array = new int[b - a + 1][];

                            for (int i = 0; i < array.Length; i++)
                            {
                                array[i] = new int[a];
                                a++;
                            }
                            for (int i = 0; i < array.Length; i++)
                            {
                                for (int q = 0; q < array[i].Length; q++)
                                {
                                    array[i][q] = c;
                                    Write($"{array[i][q]} ");
                                }
                                c++;
                                WriteLine();
                            }
                            WriteLine("Press Enter");
                        }
                        break;
                    default:
                        WriteLine("Error action, press Enter");
                        break;
                }
                ReadLine();
            } while (true);



        }
    }
}
