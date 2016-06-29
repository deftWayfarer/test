using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int total = 2147483647;
        try
        {
            total = checked(total * 2);
            Console.WriteLine("Result is: {0}", total);
        }
        catch
        {
            Console.WriteLine("Overflow! Data was lost!");
        }
        Console.ReadKey();
    }
}