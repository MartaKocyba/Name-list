using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {


            bool Rekurencja(int x, int y)
            {
                x = x - 1;

                if (x == 1)
                {
                    //return 1;
                    return true;
                }
                else if (y == 2)
                {
                    //return 2;
                    return true;
                }
                else if (y % 2 == 0)
                {
                    //return 3;
                    return false;
                }
                else if (y % x == 0)
                {
                    //return x;
                    return false;
                }
                else if (x == 0)
                {
                    //return 5;
                    return false;
                }


                //if ( (x == 0)(x == 1) )
                //{
                //    return false;
                //}



                return Rekurencja(x, y);
            }


            Console.WriteLine("Czy liczba jest liczbą pierwszą \nPodaj liczbę naturalną (oprócz 0 i 1): ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 1 && number == 0)
            {
                Console.Clear();
                Console.WriteLine("Liczba jest równa 0 lub 1");
            }
            else if (number > 1)
            {
                if (Rekurencja(number, number))
                {
                    Console.WriteLine("Liczba jest liczbą pierwszą");
                }
                else
                {
                    Console.WriteLine("Liczba NIE jest liczbą pierwszą");
                }

            }
            else
            {
                Console.WriteLine("Podano nieprawidłową liczbę.");
            }

            Console.ReadKey();
        }
    }
}