using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину масссива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new();
            Console.WriteLine("Изначальный массив, Z(N):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int newLength = n;

            bool sign = array[0] > 0;
            for (int i = 0; i < n - 1; i++)
            {
                //if (sign = true && array[i + 1] > 0)
                //{
                //    array[i + 1] = 0;
                //    newLength--;
                //    sign = !sign;
                //}
                //else if (sign = false && array[i + 1] < 0)
                //{
                //    array[i + 1] = 0;
                //    newLength--;
                //    sign = !sign;
                //}
                if (array[i] > 0)
                {
                    if (array[i + 1] > 0)
                    {
                        array[i + 1] = 0;
                        newLength--;
                    }
                    else if (array[i + 1] < 0)
                    {
                        sign = !sign;
                    }
                    else
                    {

                    }                    
                }
                else if (array[i] < 0)
                {
                    if (array[i + 1] > 0)
                    {
                        sign = !sign;
                    }
                    else if (array[i + 1] < 0)
                    {
                        array[i + 1] = 0;
                        newLength--;
                    }
                    else
                    {

                    }
                }
            }

            
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    if (sign == true && array[i] != 0)
            //    {
            //        for (int j = i + 1; sign == true && j < array.Length; j++)
            //        {
            //            if (array[j] > 0)
            //            {
            //                array[j] = 0;
            //            }
            //            else
            //            {
            //                sign = !sign;
            //            }
            //        }
            //    }
            //    else if (sign == false && array[i] != 0)
            //    {
            //        for (int j = i + 1; sign == false && j < array.Length; j++)
            //        {
            //            if (array[j] < 0)
            //            {
            //                array[j] = 0;
            //            }
            //            else
            //            {
            //                sign = !sign;
            //            }
            //        }
            //    }
            //}

            int[] newArray = new int[newLength];
            int q = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] != 0)
                {
                    newArray[q] = array[i];
                    q++;
                }
            }

            Console.WriteLine("Вывод отсортированного массива.");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(newArray[i] + " ");
            }
        }
    }
}
