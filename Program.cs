using System;

namespace for_1
{
    public struct Result
    {
        public int min1;
        public int min2;
        public int max1;
        public int max2;
    }
    public class Logic

    {
       
        public static Result FindAll(int[] Arr)
        {
            var m = new Result();
            m.min1 = Logic.GetMin1(Arr);
            m.min2 = Logic.GetMin2(Arr);
            m.max1 = Logic.GetMax1(Arr);
            m.max2 = Logic.GetMax2(Arr);
            return m;
        }
        public static int GetMin1(int[] Arr)
        {
            
            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_min1 = Arr[0];
            return sum_min1;
        }
        public static int GetMin2(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_min2 = Arr[1];
            return sum_min2;
        }
        public static int GetMax1(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_max1 = Arr[Arr.Length - 1];
            return sum_max1;
        }
        public static int GetMax2(int[] Arr)
        {

            int temp;

            for (int i = 0; i < Arr.Length - 1; i++)
            {

                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            int sum_max2 = Arr[Arr.Length - 2];
            return sum_max2;
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
             
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int [n];
            for (int i = 0; i < n ; i++)
            {
               Arr [i] =  int.Parse(Console.ReadLine());
            }


            var m = Logic.FindAll(Arr);
            Console.WriteLine($"Первое макс число: {m.max1}, Второе макс число: {m.max2}, Первое мин число: {m.min1}, Второе мин число: {m.min2}");

        }
    }
}
