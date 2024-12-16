using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int l = numbers[0];
                int n = numbers[1];

                Dictionary<int, int> playList = new Dictionary<int, int>();

                for (int i = 0; i < n; i++)
                {
                    numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    playList.Add(i + 1, numbers[0] * 60 + numbers[1]);
                }

                int counter = 0;
                while (l > 0)
                {
                    counter++;
                    counter = counter > n ? 1 : counter;
                    l -= playList[counter];
                }

                Console.WriteLine(counter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
