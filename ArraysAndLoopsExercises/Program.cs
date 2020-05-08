using System;

namespace ArraysAndLoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Reverse Counting");
                Console.WriteLine("7. Restaurant Bill");
                Console.WriteLine("8. Age Category");
                Console.WriteLine("9. Words to Digits");
                Console.WriteLine("10. Which Name is Longer?");
                Console.WriteLine("11. Are these Numbers the Same?");
                Console.WriteLine("12. Name and Place of Birth");
                Console.WriteLine("13. Sort the Numbers");
                Console.WriteLine("14. Shopping List");
                Console.WriteLine("15. What's the Longest Word?");
                Console.WriteLine("16. What's the Second to Last Word?");
                Console.WriteLine("17. Which Day of the Week?");
                Console.WriteLine("18. Print a Triangle");
                Console.WriteLine("19. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        ReverseCounting();
                        break;
                    case "7":
                        RestaurantBill();
                        break;
                    case "8":
                        AgeCategory();
                        break;
                    case "9":
                        WordsToDigits();
                        break;
                    case "10":
                        WhichNameIsLonger();
                        break;
                    case "11":
                        AreNamesSame();
                        break;
                    case "12":
                        NameAndBirthplace();
                        break;
                    case "13":
                        SortNumbers();
                        break;
                    case "14":
                        ShoppingList();
                        break;
                    case "15":
                        LongestWord();
                        break;
                    case "16":
                        SecondToLastWord();
                        break;
                    case "17":
                        WhichDayOfWeek();
                        break;
                    case "18":
                        PrintTriangle();
                        break;
                    case "19":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
