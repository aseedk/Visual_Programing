using System;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*string[] valosquad = {"Aseed", "Ammar", "Hurairah", "Mohib", "Hashim"};
            foreach (string i in valosquad)
            {
                Console.WriteLine(i + " SUCKS!!!");
            }*/
            /*int[] ints = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }*/
            /*
            int[] ints = new int[5];
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }*/
            /*int[] ints = new int[] {1, 2, 3, 4, 5};
            foreach (var VARIABLE in ints)
            {
                Console.WriteLine(VARIABLE);
            }*/
            /*int[,] arr2d = new int[3,2]{ 
                {1, 2}, 
                {3, 4}, 
                {5, 6} 
            };
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write(arr2d[i,j] + ",");
                }
                Console.WriteLine();
            }*/
            /*int[,] arr2d = new int[3, 3];
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write("Enter A number in Postion:" + i  + "," + j+": ");
                    var num = Convert.ToInt32(Console.ReadLine());
                    arr2d[i, j] = num;
                }
            }
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    Console.Write(arr2d[i,j] + ", ");
                }
                Console.WriteLine();
            }*/
            /*int[,] arr2d = {{1, 2}, {2, 3}};
            foreach (var VARIABLE in arr2d)
            {
                Console.WriteLine("{0} ", VARIABLE);
            }*/
            /*int[][] jaggedArray =
            {
                new int[5] { 1, 3, 5, 7, 9 },
                new int[4] { 0, 2, 4, 6 },
                new int[2] { 11, 22 }
            };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + ", ");
                }
                Console.WriteLine("} ");
            }

            foreach (var variable in jaggedArray)
            {
                Console.WriteLine(variable);
            }*/
            /*string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            PrintArray(days);
            ChangeArrayElement(days);
            PrintArray(days);
            ReverseArray(days);
            PrintArray(days);*/
            string[] strings = {"HELLO", "I", "Am", "IDK!!!"};
            var sentence = StringMethod(strings);
            {
                Console.Write(sentence);
            }
        }
        private static string StringMethod(string[] strings)
        {
            var temp = "";
            foreach (var VARIABLE in strings) temp = temp + VARIABLE + " ";

            return temp;
        }
        
        /*static void PrintArray(string[] array)
        {
            Console.Write("{ ");
            foreach (var variable in array)
            {
                Console.Write(variable + ", ");
            }
            Console.WriteLine("}");
        }

        static void ChangeArrayElement(string[] array)
        {
            string temp = array[0];
            array[0] = array[6];
            array[6] = temp;
        }

        static void ReverseArray(string[] array)
        {
            Array.Reverse(array);
        }*/
    }

}
