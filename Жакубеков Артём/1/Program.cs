using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int result = numbers.OrderByDescending(n => (n / 10) % 10 + n % 10).ThenBy(n => n).First();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
