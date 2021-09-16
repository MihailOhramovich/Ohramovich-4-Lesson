using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    

    #region Описание класса MyArray
    class MyArray
    {
        int[] arr;

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        
        /// <summary>
        /// Генерация массива случайных чисел от -100 до 99
        /// </summary>
        /// <param name="index">Размер массива </param>
        public MyArray(int index)
        {
            Random random = new Random();
            arr = new int[index];
             
            for (int i = 0; i < index; i++)
            {
                int number = random.Next(-10000,10001);//рандомное число от -10000 до 10000 
                arr[i] = number;
            }
            
            

            

        }
        /// <summary>
        /// Сортировка массива
        /// </summary>
        public void Sort()
        {
            Array.Sort(arr);
        }
        /// <summary>
        /// Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом 
        /// </summary>
        /// <param name="index">Размер массива</param>
        /// <param name="value">Начальное значение</param>
        /// /// <param name="step">шаг</param>
        public MyArray(int index, int value, int step)
        {
            arr = new int[index];
            arr[0] = value;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i-1] + step;
            }
        }
        public int Length()
        {
            int y;
            y=arr.Length;
            return y;
        }
        public int[] Inverse(int[]d)
        {
            int[] nd = new int[arr.Length];
            for (int i = 0; i < arr.Length;i++)
                {
                    nd[i] = arr[i]*-1;
                }
            Print(nd);            
            return nd;
        }


        public void Sum()
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                counter = arr[i] + counter;
            }
            Console.Write($"Сумма элементов массива = {counter}");
            Console.WriteLine();
        }
        public void multi(int value)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= value;
            }
            
            Console.WriteLine();
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        public void Print(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
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
        #endregion










    }
    class Program
    {
        public static string[] LoadArrayFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    string[] buf = new string[1000];
                    int counter = 0;

                    while (!reader.EndOfStream)
                    {
                        buf[counter] = reader.ReadLine();
                        counter++;
                    }

                    string[] arr = new string[counter];

                    Array.Copy(buf, arr, counter);

                    return arr;

                }

                //StreamReader reader = new StreamReader(fileName);
                //try
                //{

                //}
                //finally
                //{
                //    reader.Dispose();
                //}


            }
            else
            {
                throw new FileNotFoundException();
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
            Console.WriteLine("Введите номер задачи для ее выполнения!\n 1-1 задача\n 2-2 задача\n 3-3 задача\n 0-EXIT");
            int taskNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("================");
            do
            {


                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.");
                        MyArray arr1 = new MyArray(20);
                        arr1.Print();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Реализуйте задачу 1 в виде статического класса StaticClass;");
                        Console.WriteLine("Сделанно!");
                        break;

                    case 3:
                        Console.WriteLine("a)Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.\nb) Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.\n");
                        break;

                    

                 
                    default:
                        Console.Write("Неккоректный ввод задачи попробуйте снова");
                        return;
                }
            }
                while (taskNumber != 0);
                Console.ReadLine();
            


            
    


               







            
            

            
            
            
            
            
            
            
            
        }
    }
}
