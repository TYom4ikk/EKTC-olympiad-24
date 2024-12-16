using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int N = numbers[0]; // Базы врага
                int M = numbers[1]; // Пусковые установки
                int S = numbers[2]; // Снаряды
                int[] b = new int[N]; // Абциссы баз
                int[] l = new int[M]; // Абциссы установок
                int[] d = new int[S]; // дальность снарядов
                int lenght = 1000;


                b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                l = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                d = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


                List<int> ableToShootIndexes = new List<int>();
                List<int> ableToShootDistance = new List<int>();
                //РАСЧЁТЫ
                int destroyed_base = 0;
                for (int i = 0; i < N; i++)
                {
                    int base_coordinate = b[i];
                    int near_rocket_launcher;

                    double less_Gipotenusa = double.MaxValue;
                    int indexOfLessGipotenusa = -1;
                    double rocketDistance = -1;

                    double gipotenusa;
                    for (int j = 0; j < M; j++)
                    {
                        near_rocket_launcher = l[j];
                        if (base_coordinate == l[j])
                        {
                            near_rocket_launcher = l[j];
                            rocketDistance = lenght;
                            break;
                        }
                        else
                        {
                            gipotenusa = Math.Sqrt(Math.Pow(lenght, 2) + Math.Pow(
                                Math.Abs(base_coordinate - near_rocket_launcher), 2));
                            if (less_Gipotenusa > gipotenusa)
                            {
                                less_Gipotenusa = gipotenusa;
                                indexOfLessGipotenusa = j;
                                rocketDistance = less_Gipotenusa;
                            }
                        }

                    }
                    ableToShootIndexes.Clear();
                    ableToShootDistance.Clear();
                    for (int j = 0; j < S; j++)
                    {
                        if (d[j] >= rocketDistance)
                        {
                            ableToShootIndexes.Add(j);
                            ableToShootDistance.Add(d[j]);
                        }
                    }
                    if (ableToShootIndexes.Count > 0)
                    {
                        int index = ableToShootDistance.IndexOf(ableToShootDistance.Min());
                        d[ableToShootIndexes[index]] = 0;

                        destroyed_base++;
                    }
                }
                Console.WriteLine(destroyed_base);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
