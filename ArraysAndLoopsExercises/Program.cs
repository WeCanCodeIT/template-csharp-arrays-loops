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
                Console.WriteLine("ARRAYS AND LOOPS EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Sort the Numbers");
                Console.WriteLine("2. Which Day of the Week?");
                Console.WriteLine("3. Print a Triangle");
                Console.WriteLine("4. Guess the Magic Number");
                Console.WriteLine("5. Print Numbers in Reverse Order");
                Console.WriteLine("6. Print the Square of Even Numbers");
                Console.WriteLine("7. Find the Smallest Number in an Array");
                Console.WriteLine("8. Common Values");
                Console.WriteLine("14. Shopping List");
                Console.WriteLine("15. What's the Longest Word?");
                Console.WriteLine("16. What's the Second to Last Word?");

                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        SortTheNumbers();
                        break;
                    case "2":
                        WhichDayOfWeek();
                        break;
                    case "3":
                        PrintTriangle();
                        break;
                    case "4":
                        GuessTheMagicNumber();
                        break;
                    case "5":
                        NumbersInReverse();
                        break;
                    case "6":
                        SquareOfEvenNumbers();
                        break;
                    case "7":
                        SmallestNumberInArray();
                        break;
                    case "8":
                        CommonValues();
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

        static void SortTheNumbers()
        {
            // Ask 10 people for their favorite numbers and create an array of those numbers. 
            // Order the numbers using the sort method. Print the first and last numbers.

            Console.Clear();
            Console.WriteLine("SORT THE NUMBERS\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichDayOfWeek()
        {
            // Declare and initialize a string array with the 7 days of the week. 
            // Print the number corresponding to each day and the day of the week. (1 = Sunday, 2 = Monday, etc.)

            // Ask the user for a number between 1 - 7.
            // Print the day of the week that corresponds to the number
            
            Console.Clear();
            Console.WriteLine("WHICH DAY OF THE WEEK?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void PrintTriangle()
        {
            // Ask the user for a number between 3 and 6. 
            // Print one asterisk to the screen. 
            // On the next line print 2 asterisks, and continue until the users number is reached.

            Console.Clear();
            Console.WriteLine("PRINT A TRIANGLE\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessTheMagicNumber()
        {
            // Ask the user for an integer. 
            // If that integer is evenly divisible by 3, then print “You Won!”. 
            // If it isn’t, ask the user to “Try again.” 
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SquareOfEvenNumbers()
        {
            // Print the sqaures (the number multipied by itself) for even numbers between 1-9.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SmallestNumberInArray()
        {
            // Ask the user for 5 integers and save them in an array. 
            // Find the smallest number in the array and write it to the screen.

            Console.Clear();
            Console.WriteLine("FIND THE SMALLEST NUMBER IN AN ARRAY\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void CommonValues()
        {
            // You are given 3 arrays of the same size, where 1 is empty and 2 have values. 
            // Use nested loops to find the values that are common between the 2 arrays.

            Console.Clear();
            Console.WriteLine("COMMON VALUES\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void ShoppingList()
        {
            // Initialize an array with 4 food items. Print this shopping list to the console.

            Console.Clear();
            Console.WriteLine("SHOPPING LIST\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void LongestWord()
        {
            // Ask the user for a phrase consisting of 1-4 words (no punctuation).
            // Print the longest word in the phrase. If 2 words have the same length, print both.

            Console.Clear();
            Console.WriteLine("WHAT'S THE LONGEST WORD?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SecondToLastWord()
        {
            // Ask the user for a sentence or phrase consisting of at least 4 words.
            // Find the second to last word and print it.

            Console.Clear();
            Console.WriteLine("WHAT'S THE SECOND TO LAST WORD?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}


