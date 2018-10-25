using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sortList = new List<int>();

            //randomly generate 100K integer
            Random rnd = new Random();
            Console.Write("Enter a list count: ");
            var input = Console.ReadLine();
            
            int.TryParse(input, out int inputNumber);
            for ( var num =1; num <=inputNumber;num++)
            {
                sortList.Add(rnd.Next(9999));
            }

            DisplaySortList(sortList, inputNumber);

            Console.WriteLine();
            Console.WriteLine(" Sorting ...");

            int i, j;
            //sorting algorithm 
            // i index is  Key compare to the element  to its left (i-1)=>j
            for (i = 1; i < sortList.Count(); i++)
            {
                int key = sortList[i];
                for (j = (i - 1); j >= 0; j--)
                {
                    int current = sortList[j];
                    if (key <= current)
                    {
                        sortList[j] = key;
                        sortList[j+1] = current;
                    }
                }

               
            }

            DisplaySortList(sortList, inputNumber);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Sorting completed. Press any key ..");
            Console.ReadLine();
        }
        private static void DisplaySortList(List<int> _list, int inputNum)
        {
            try
            {
                for (int output = 0; output <= ((inputNum -1)% 100); output++)
                {
                    if ((output % 5) == 0)
                    {
                        Console.WriteLine();
                    }
                    Console.Write(_list[output].ToString() + ' ');
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
