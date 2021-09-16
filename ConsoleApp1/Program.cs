using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    }
    class Program
    {
    class MyArray
    {
        int[] arr;
        public MyArray(int[] arr)
        {
            this.arr = arr;
            
        }


        /// <summary>
        /// Генерация случайного массива из count элементов
        /// </summary>
        /// <param name="count"></param>
        public MyArray(int count)
        {
            Random random = new Random();

            arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                int number = random.Next(-10000, 10000);
                arr[i] = number;
            }
        }

        /// <summary>
        /// Метод создания отсартированного массива со случайными числами от -10 000 до 9 999.
        /// </summary>
        /// <param name="count">Размер массива</param>
        
        

        

        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        public int GetElement(int index)
        {
            return arr[index];
        }
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }






    }
    static int GetIndex(int[] arr, int b)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == b)
                return i;
        }
        return -1;
    }
    static void Main(string[] args)
        {
         
            MyArray arr1 = new MyArray(20);
        Array.Sort(MyArray arr1);
        arr1.Print();
        Console.ReadKey();
        int counter = 0;
        for (var i = 0; i < 10; i++)
        {
            
            if (arr1[i] % 3 == 0 && arr1[i + 1] % 3 != 0)
                counter++;
                

        }
        Console.WriteLine($"Пары чисел подходящие под условия задачи их количество = {counter}");

        Console.ReadKey();

    }
           
    }



