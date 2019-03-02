using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            task_4();
        }



        static void task_1()
        {
            List<int> numbers = new List<int>() { 36, 718, 372, 648 };
            numbers.Sort();
            Console.WriteLine("Second max element: {0} \n Index: ", numbers[numbers.Count - 1], (numbers.Count - 1));


        }



        static void task_2()
        {
            List<int> numbers = new List<int>() { 468, 4664, 396, 174, 54, 84 };
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                    numbers.RemoveAt(i);
            }
        }



        static void task_3()
        {
            List<double> numbers = new List<double>() { 11.6, 24.5, 3.14, 45.6 };
            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
                sum += numbers[i];

            Console.WriteLine("Average: {0}", sum / numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] > sum / numbers.Count)
                    Console.WriteLine("Element above average {0}", numbers[i]);
        }



        static void task_4()
        {
            string str = Console.ReadLine();
            string trs = Console.ReadLine();
            if (str.Reverse() == trs)
                Console.WriteLine("String identical");
            else
                Console.WriteLine("Strings not identical");
        }



        static void task_5()
        {
        }



        static void task_6()
        {
        }



        static void task_7()
        {
        }



        static void task_8()
        {
        }



        static void task_9()
        {
        }

















    }
}
