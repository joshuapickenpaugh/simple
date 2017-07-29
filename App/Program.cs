//Joshua Pickenpaugh
//July 29, 2017
//Simple

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lstDouble = new List<double>();

            Console.WriteLine("How many numbers do you wish to enter?:");
            int intUserSelect = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter some numbers: ");
            for (int x = 1; x <= intUserSelect; x++)
            {
                double dblUserNum = Convert.ToDouble(Console.ReadLine());
                lstDouble.Add(dblUserNum);
            }

            foreach (double num in lstDouble)
            {
                Console.Write(num + ",");
            }

            Console.ReadKey();

        }
    }
}
