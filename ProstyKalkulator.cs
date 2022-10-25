using System;
using System.Collections;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Start.
            //Nie mam zielonego pojęcia jak lepiej to zrobić, więc aby konsola po stronie użytkownika była bardziej czytelna, rozdzielam niektóre linijki znakiem "_".


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Kalkulator do podstawowych obliczeń");
            Console.WriteLine("Czy chcesz rozpocząć? (TAK/NIE)");
            var UserInput1 = Console.ReadLine().ToUpper();

            switch (UserInput1)
            {
                case "TAK":
                    Console.WriteLine("Uruchamiam Kalkulator");
                    Console.WriteLine("_____________________________");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zamykam Kalkualtor");
                    Console.WriteLine("Program zamknie się automatycznie za 4 sekundy");
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                    break;

            }
            do
            {
                //Wybór rodzaju działań
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jaką operację chcesz wykonać?");
                Console.WriteLine("(Wpisz numer przypisany do typu działania)");
                Console.WriteLine("__________________________________________");
                Console.WriteLine("Możliwe do wybooru to:\n(1) Dodawanie \n(2) Odejmowanie \n(3) Mnożenie \n(4) Dzielenie \n(5) Potęgowanie \n(6) Wyliczanie % z danej liczby \n(7) Pierwiastkowanie  ");
                Console.WriteLine("__________________________________________");
                var OperationType = Console.ReadLine();

                //żeby To.Double mogło zadziałać
                double number1 = 0;
                double number2 = 0;
                double result = 0;


                //
                //działania
                switch (OperationType)
                {
                    case "1":
                        //zmiana koloru konsoli
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś dodawanie.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj pierwszą drugą liczbę:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 + number2;
                        Console.WriteLine($"Twoje działanie: {number1} + {number2} = {result}");
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś odejmowanie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 - number2;
                        Console.WriteLine($"Twoje działanie: {number1} - {number2} = {result}");
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś mnożenie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj liczbę którą chcesz pomnożyć:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj liczbę przez którą chcesz przemnożyć:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 * number2;
                        Console.WriteLine($"Twoje działanie: {number1} * {number2} = {result}");
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś dzielenie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj liczbę którą chcesz podzielić:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Podaj liczbę przez którą chcesz podzielić:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number1 / number2;
                        Console.WriteLine($"Twoje działanie: {number1} / {number2} = {result}");
                        break;


                    case "5":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś potęgowanie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj liczbę którą chcesz spotęgować:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Do jakiej potęgi chcesz ją podnieść?: ");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = Math.Pow(number1, number2);
                        Console.WriteLine($"Twoje działanie: {number1}^{number2} = {result}");
                        break;

                    case "6":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś obliczanie procentów z danej liczby");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj liczbę z której chcesz wyliczyć dany %:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Jaki % chcesz wyliczyć?:");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = number2 / 100 * number1;
                        Console.WriteLine($"{number2}% z {number1} to {result}");
                        break;


                    case "7":
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Wybrałeś pierwiastkowanie");
                        Thread.Sleep(1000);
                        Console.WriteLine("Podaj liczbę z której chcesz wyliczyć pierwiastek:");
                        number1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Jaki stopień pierwiastka chcesz wyliczyć?");
                        number2 = Convert.ToDouble(Console.ReadLine());
                        result = Math.Pow(number1, 1 / number2);
                        Console.WriteLine($"pierwiastek {number2} stopnia z {number1} to: {result}");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nie wybrałeś żadnej z powyższych opcji.");
                        break;

                }


                //powtórzenie
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Czy chciałbyś dokonać dalszych obliczeń?(TAK/NIE)");
            } while (Console.ReadLine().ToUpper() == "TAK");


            //Zakończenie
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kalkulator wyłączy się.");
            Thread.Sleep(2000);
            Environment.Exit(0);

            Console.ReadKey();




            /* Program ma jedną i dość zasadniczą wade. 
               Wysypie się jeśli użytkownik podczas wpisywania 
               po wyborze typu obliczeń, wpisze cokolwiek innego
               np: literę lub znak specjalny. Muszę pamiętać aby 
               to poprawić. 
            */

        }
    }
}