using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                string tempStr = "";
                char[] maxString = "".ToCharArray();
                bool IsLenghtGot = false;
                int lenght=0;
                for (int i = 0; i < n; i++)
                {
                    string str = Console.ReadLine();

                    if (!IsLenghtGot)
                    {
                        lenght = str.Length;
                        for (int k = 0; k < lenght; k++)
                        {
                            tempStr += "A";
                        }
                        maxString = tempStr.ToCharArray();
                        IsLenghtGot = true;
                    }

                    for (int j = 0; j < lenght; j++)
                    {
                        if (str[j] > maxString[j])
                        {
                            maxString[j] = str[j];
                        }
                    }
                }
                Console.WriteLine(maxString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
