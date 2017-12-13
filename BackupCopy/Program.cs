using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupCopy
{
    class Program
    {
        const int STORAGE_SIZE = 3;
        static void Main(string[] args)
        {
            
            Storage[] storage = new Storage[STORAGE_SIZE];
            storage[0] = new Flash();
            storage[1] = new DVD();
            storage[2] = new HDD();

            bool switchForWhile = true;
            int h = 0;
            while (switchForWhile)
            {
                Console.WriteLine("0- Выход");
                Console.WriteLine("1- Расчет общего количества памяти всех устройств");
                Console.WriteLine("2- Копирование информации на устройства");
                Console.WriteLine("3- Расчет времени необходимого для копирования");
                Console.WriteLine("4- Расчет необходимого количества носителей информации представленных типов для переноса информации");
                h = int.Parse(Console.ReadLine());
                switch (h)
                {
                    case 0: switchForWhile = false; break;
                    case 1: GetAllMemory(storage); break;
                    case 2: CopyInformation(storage); break;
                    case 3: GetTimeCopy(storage); break;
                    case 4: GetCountStorage(storage); break;
                }
                Console.Clear();
            }
        }

        static void GetAllMemory(Storage[] storage)//1 method
        {
            int AllMemory = 0;
            for (int i = 0; i < STORAGE_SIZE; i++)
            {
                AllMemory = AllMemory + storage[i].GetMemory();
            }
            Console.WriteLine("Общая память всех устройств; " + AllMemory);
        }

        static void CopyInformation(Storage[] storage)//2 method
        {
            Console.WriteLine("Введите размер информации которую вы хотите скопировать");
            int requiredAmountOfMemory = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //ToDo

        }

        static void GetTimeCopy(Storage[] storage)//3 method
        {
            //ToDo
        }

        static void GetCountStorage(Storage[] storage)//4 method
        {
            //ToDo
        }
    }
}
