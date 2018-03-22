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
            string introMessage = "Please enter a series of integer , sperate them with comma" + System.Environment.NewLine
            +" i.e.  1,4,88,4,7,4,12";
            Console.WriteLine(introMessage);

            string readStr = Console.ReadLine();

            string[] inputSplit = readStr.Split(',');

            // veriffy each input is integer
            foreach (var j1 in inputSplit)
            {
                int.TryParse(j1, out int a);
                sortList.Add(a);
                Console.WriteLine(a.ToString());
            }
            int i, j, k;
            
            for (i=1; i== sortList.Count() ;i++)
            {
                int current = sortList[i];
                j = 0;
                while ( j<=i)
                {
                    if ( current<sortList[j] && j!=0)
                    {
                        //swap
                        sortList[i] = sortList[j];
                        sortList[j] = current;
                        j = i + 1; //exit this loop
                    }
                    else
                    {
                        j++;
                        //do nothing and go to next number
                    }
                    foreach (var prt in inputSplit)
                    {
                        Console.Write(prt.ToString());
                    }
                }
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
