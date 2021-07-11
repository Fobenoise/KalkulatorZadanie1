using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorZadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        static void Calculate()
        {
            var no1 = RozparsujDecymala("Podaj argument #1: ");

        
            Console.Write("Podaj operator: ");
            var k = Console.ReadLine();


            var no2 = RozparsujDecymala("Podaj argument #2: ");





            switch (k)
            {
                case "+":
                    {
                        Console.WriteLine("Wynik to = {0}", no1 + no2);

                        break;
                    }

                case "-":
                    {
                        Console.WriteLine("Wynik to = {0}", no1 - no2);

                        break;
                    }

                case "*":
                    {
                        Console.WriteLine("Wynik to = {0}", no1 * no2);

                        break;
                    }

                case "/":
                    {
                        no2 = DzielenieZero(no2);


                        Console.WriteLine("Wynik to = {0}", no1 / no2);


                        break;
                                          
                    }

                default:
                    Console.WriteLine("Nieprawidlowy operator");
                    break;
            }





            Calculate();
        }

        static decimal RozparsujDecymala(string komunikat)
        {
            Console.Write(komunikat);
            var liczba = Console.ReadLine();
            if (!Decimal.TryParse(liczba, out var sparsowanyDecymal))
            {
                Console.WriteLine("Niepoprawny argument");
                RozparsujDecymala(komunikat);

            }
            return sparsowanyDecymal;
        }
        static decimal DzielenieZero(decimal liczba)
        {
            
            if (liczba == 0)
            {
                Console.WriteLine("Dzielenie przez zero kurwa!!!");
                liczba = RozparsujDecymala("Podaj argument #2: ");
                liczba = DzielenieZero(liczba);

            }
            return liczba;
        }

    }
}
