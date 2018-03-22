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
            + " i.e.  1,4,88,4,7,4,12";
            Console.WriteLine(introMessage);

            // string readStr = Console.ReadLine();
            string readStr = "5,3,2,1,9,8,6"; //for testing purpose
            string[] inputSplit = readStr.Split(',');

            // veriffy each input is integer
            foreach (var j1 in inputSplit)
            {
                int.TryParse(j1, out int a);
                sortList.Add(a);
            }
            int i, j, k;

            for (i = 1; i <= sortList.Count(); i++)
            {
                j = i - 1;
                while (j >= 0)
                {

                    int current = sortList[i];
                    int compare = sortList[j];
                    if (current < compare)
                    {
                        //swap  current and compare
                        sortList[j] = current;
                        sortList[i] = compare;
                        i--;
                    }
                    j--;
                }
                Console.WriteLine(sortList.ToString());
            }
            Console.Read();
        }

    }
}
