using System;
using System.Threading;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.WriteLine("Wybierz tryb gry");
                Console.WriteLine("1. Przedział od 0 do 100.");
                Console.WriteLine("2. Własny (Wybierz przedział samodzielnie");
                Console.WriteLine("3. Wjście");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        CasualGame();
                        break;

                    case "2":
                        Console.Clear();
                        CustomGame();
                        break;

                    case "3":
                        isAppRunning = false;
                        break;

                    default:
                        Console.WriteLine("Niepoprawna wartość. Wybierz opcje od 1 do 4.");
                        break;
                }
            }
        }

        public static void CasualGame()
        {
            Random random = new Random();
            int guessingValue = random.Next(1, 100);

            Console.WriteLine("Odgadnij liczbę od 1 do 100.");

            int userGuess = 0;
            int userAttempts = 0;

            while (userGuess != guessingValue)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    userAttempts++;

                    if (userGuess > guessingValue)
                    {
                        Console.WriteLine("Podana liczba jest za duża. Spróbuj ponownie.");
                    }

                    if (userGuess < guessingValue)
                    {
                        Console.WriteLine("Podana liczba jest za mała. Spróbuj ponownie.");
                    }

                    if (userGuess == guessingValue)
                    {
                        Console.WriteLine($"Brawo! Odgadłeś przy: {userAttempts} próbie!");
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Podana wartość musi być liczbą całkowitą. Spróbuj ponownie.");
                }
            }
        }

        public static void CustomGame()
        {
            Console.WriteLine("Musisz podać zakres liczb, w którym chcesz zgadywać.");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Zakres od {firstNumber} do {secondNumber}");

            Random random = new Random();
            int guessingValue = random.Next(firstNumber, secondNumber);

            Console.WriteLine($"Odgadnij liczbę od {firstNumber} do {secondNumber}.");

            int userGuess = 0;
            int userAttempts = 0;

            while (userGuess != guessingValue)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    userAttempts++;

                    if (userGuess > guessingValue)
                    {
                        Console.WriteLine("Podana liczba jest za duża. Spróbuj ponownie.");
                    }

                    if (userGuess < guessingValue)
                    {
                        Console.WriteLine("Podana liczba jest za mała. Spróbuj ponownie.");
                    }

                    if (userGuess == guessingValue)
                    {
                        Console.WriteLine($"Brawo! Odgadłeś przy: {userAttempts} próbie!");
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Podana wartość musi być liczbą całkowitą. Spróbuj ponownie.");
                }
            }
        }
    }
}
