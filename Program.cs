using System;

namespace BioProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean flag to keep the program running
            bool running = true;

            while (running)
            {
                // Display the main menu
                Console.WriteLine("Huvudmeny:");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine("2. Räkna ut pris för ett sällskap");
                Console.WriteLine("3. Upprepa text tio gånger");
                Console.WriteLine("4. Visa tredje ordet i en mening");
                Console.WriteLine("0. Avsluta programmet");
                Console.Write("Välj ett alternativ: ");

                // Read user input
                string choice = Console.ReadLine();

                // Switch-case to handle user input
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        CheckAgeForPrice();
                        break;
                    case "2":
                        CalculateGroupPrice();
                        break;
                    case "3":
                        RepeatTextTenTimes();
                        break;
                    case "4":
                        DisplayThirdWord();
                        break;
                    default:
                        Console.WriteLine("Felaktig input. Försök igen.");
                        break;
                }
            }
        }

        // Method to check the price based on age
        static void CheckAgeForPrice()
        {
            Console.Write("Ange din ålder: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr");
                }
            }
            else
            {
                Console.WriteLine("Felaktig input. Ange en siffra.");
            }
        }

        // Method to calculate the total price for a group
        static void CalculateGroupPrice()
        {
            Console.Write("Hur många är ni i sällskapet? ");
            if (int.TryParse(Console.ReadLine(), out int numberOfPeople))
            {
                int totalCost = 0;

                for (int i = 0; i < numberOfPeople; i++)
                {
                    Console.Write($"Ange ålder för person {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        if (age < 5 || age > 100)
                        {
                            totalCost += 0;
                        }
                        else if (age < 20)
                        {
                            totalCost += 80;
                        }
                        else if (age > 64)
                        {
                            totalCost += 90;
                        }
                        else
                        {
                            totalCost += 120;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig input. Ange en siffra.");
                        i--; // Retry the current person's age input
                    }
                }

                Console.WriteLine($"Antal personer: {numberOfPeople}");
                Console.WriteLine($"Totalkostnad för hela sällskapet: {totalCost}kr");
            }
            else
            {
                Console.WriteLine("Felaktig input. Ange en siffra.");
            }
        }

        // Method to repeat a user input text ten times
        static void RepeatTextTenTimes()
        {
            Console.Write("Ange en text: ");
            string input = Console.ReadLine();
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {input} ");
            }

            Console.WriteLine(); // For a new line after the repeated text
        }

        // Method to display the third word in a sentence
        static void DisplayThirdWord()
        {
            Console.Write("Ange en mening med minst 3 ord: ");
            string input = Console.ReadLine();

            // Split the sentence into words
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Check if there are at least 3 words
            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}");
            }
            else
            {
                Console.WriteLine("Mening innehåller inte minst 3 ord.");
            }
        }
    }
}