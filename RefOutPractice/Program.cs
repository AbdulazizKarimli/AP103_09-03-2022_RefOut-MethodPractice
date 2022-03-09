using System;

namespace RefOutPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HomeWork
            //Console.WriteLine(Repeat("Ha!"));

            //string word = Repeat("Ha!", 2);
            #endregion

            #region RefOut
            //int num=5;
            //string word;
            //ChangeNumber(ref num);
            //ChangeString(out word);
            //Console.WriteLine($"outside {word}");

            //int[] numbers = { 1, 2, 3 };
            //ChangeIndex(numbers);
            //Console.WriteLine($"outside index {numbers[0]}");

            #endregion

            #region ClassWorks
            Console.WriteLine(Pow(3,0));
            #endregion
        }

        #region ClassWorks
        static int Pow(int number, int power)
        {
            int result = number;
            if (power == 0)
                return 1;

            while (power > 1)
            {
                result *= number;
                power--;
            }

            return result;
        }
        #endregion

        #region RefOut
        static void ChangeString(out string str)
        {
            str = "a";
            Console.WriteLine(str);
        }

        static void ChangeNumber(ref int n)
        {
          // n = 10;
            Console.WriteLine($"method {n}");
        }

        //static void ChangeIndex(int[] arr) //arr = numbers
        //{
        //    arr[0] = 5;
        //    Console.WriteLine($"method index {arr[0]}");
        //}
        #endregion

        #region HomeWork
        static string Repeat(string word,int count = 1)
        {
            string result = String.Empty;

            for (int i = 0; i < count; i++)
            {
                result += word;
            }

            return result;
            //if(count > 0)
            //{
            //    int i = 0;

            //    while(i < count)
            //    {
            //        result += word;
            //        i++;
            //    }
            //}

        }

        //static int Area(int r)
        //{
        //    int p = 3;
        //    return p * r * r;
        //}

        //static int Area(int a, int b)
        //{
        //    return a * b;
        //}

        //static int Area(int a, int b, int c, int r)
        //{
        //    int p = (a + b + c) / 2;

        //    return p * r;
        //}
        #endregion
    }
}
