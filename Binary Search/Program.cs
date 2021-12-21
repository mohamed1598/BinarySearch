using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] my_List = { 1, 3, 5, 7, 9 };
            int item = 50;
            Console.WriteLine(binarySearch(my_List, item));
            Console.Read();
        }
        static object binarySearch(int[] array,int item)
        {
            int min = 0;
            int max = array.Length-1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (array[mid] == item)
                {
                    return mid;
                }
                else if(array[mid] < item)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return "not found";
        }
    }
}
