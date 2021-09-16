using System;

namespace ClassLibraryMyArray
{
    
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
                int number = random.Next(-10000, 10001);//рандомное число от -10000 до 10000 
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
                arr[i] = arr[i - 1] + step;
            }
        }
        public int Length()
        {
            int y;
            y = arr.Length;
            return y;
        }
        public int[] Inverse(int[] d)
        {
            int[] nd = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                nd[i] = arr[i] * -1;
            }
            Print(nd);
            return nd;
        }


        public void Sum()
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
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
        public void Print(int[] arr)
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
    }
}

        
    
