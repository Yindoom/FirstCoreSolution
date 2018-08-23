using System;
using System.Collections;

namespace HelloWorld
{
    class Program
    {
        public static object ConvertToInt32 { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            SayHello(Console.ReadLine());
            bool doStuff = true;
            while (doStuff)
            {
                /* THIS IS WHERE YOU CHOOSE WHAT YOU WANNA DO WITH THE PROGRAM, FROM THE LIST BELOW */
                Console.WriteLine("What do you want to do: \n" + 
                    "Math - Digits - Check (a number) - Triangle - Test (a sentence) - Swap - Fibo - Prime \n" +
                    "Factorial - Print (numbers) - Copy - Duplicate - Unique");

                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "math":
                            DoMath();
                            break;
                        case "digits":
                            SumDigits();
                            break;
                        case "check":
                            CheckEvenOrOdd();
                            break;
                        case "triangle":
                            MakePyramid();
                            break;
                        case "test":
                            SpaceTest();
                            break;
                        case "swap":
                            SwapNumbers();
                            break;
                        case "fibo":
                            Fibo();
                            break;
                        case "prime":
                            CheckPrime();
                            break;
                        case "factorial":
                            Factorial();
                            break;
                        case "print":
                            PrintNumberArray();
                            break;
                        case "copy":
                            CopyArray();
                            break;
                        case "duplicate":
                            Duplicate();
                            break;
                        case "unique":
                            Unique();
                            break;
                        default:
                            Console.WriteLine("That's not a command.");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Not a number. Try again.");
                    Console.WriteLine(e.StackTrace);
                }
                
                Console.WriteLine("Do you want to do more? y/n");
                if(Console.ReadLine() == "n")
                {
                    doStuff = false;
                }
                else if(Console.ReadLine() == "y")
                {
                    doStuff = true;
                }
            }
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        private static void Unique()
        {
            /* CHECKS AN ARRAY AND PRINTS ANY UNIQUE VALUES */
            Console.WriteLine("How long do you want the array to be?");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int[] unique = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Input number {0}", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The unique values are: ");
            for (int i = 0; i < length; i++)
            {
                int ctr = 0;
                for (int j = 0; j < length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            ctr++;
                        }
                    }
                }
                if (ctr == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void Duplicate()
        {
            /* THIS METHOD TAKES AN AMOUNT OF VALUES IN AN ARRAY AND CHECKS FOR ANY DUPLICATES */

            Console.WriteLine("How long do you want the array to be?");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int ctr = 0;
            int[] duplicate = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Input number {0}", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length -1; i++)
            {
                bool isChecked = false;
                for (int k = 0; k < duplicate.Length; k++)
                {
                    if (duplicate[k] == arr[i])
                    {
                        isChecked = true;
                    }
                }
                if (!isChecked)
                {
                    for (int j = i + 1; j < arr.Length-1; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            ctr++;
                        }
                    }
                }
            }
            Console.WriteLine("There are {0} duplicates.", ctr);
        }

        private static void CopyArray()
        {
            /* THIS COPIES ONE ARRAY TO ANOTHER */

            Console.WriteLine("How long do you want the array to be?");
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Input element {0} into the array", i+1);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("Elements in the first array are: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("\n Elements copied to the second array are: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
        }

        private static void PrintNumberArray()
        {
            /* THIS PRINTS AN ARRAY OF NUMBERS. EXCITING */ 

            Console.WriteLine("How many numbers do you want to print?");
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Type number {0} in the array", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your chosen numbers are: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Your numbers in reverse are: ");
            for (int i = arr.Length -1 ; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void Factorial()
        {
            /* THIS DOES FACTORIALS */
            Console.WriteLine("Enter number to do a factorial");
            int factor = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = factor; i > 0; i--)
            {
                sum = sum * i;
            }
            Console.WriteLine("Factorial of {0} is {1}", factor, sum);
        }

        private static void SumDigits()
        {
            /* THIS DOES MATH */

            Console.WriteLine("Type digits you want to be added together:");
            string digits = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum = sum + int.Parse(digits.Substring(i, 1));
            }
            Console.WriteLine("The sum of {0} is {1}", digits, sum);
        }

        private static void CheckPrime()
        {
            /* THIS CHECKS ANY GIVEN NUMBER FOR PRIME */
            Console.WriteLine("Type number you want to check:");
            int prime = int.Parse(Console.ReadLine());
            if(prime == 0 || prime == 1)
            {
                Console.WriteLine("{0} is not a prime", prime);
            }
            else
            {
                for (int i = 2; i < prime; i++)
                {
                    if(prime % i == 0)
                    {
                        Console.WriteLine("{0} is not a prime", prime);
                        return;
                    }
                }
                Console.WriteLine("{0} is a prime", prime);
            }
        }

        private static void Fibo()
        {
            /* THIS PRINTS FIBONACCI SEQUENCE */
            int num0 = 0;
            int num1 = 1;
            Console.WriteLine("Insert fibo number:");
            int fiboNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < fiboNumber; i++)
            {
                int temp = FiboMath(num0, num1);
                num0 = num1;
                num1 = temp;
            }
            Console.WriteLine("The fibonacci number of this number is {0}", num0);
        }

        private static int FiboMath(int num0, int num1)
        {
            /* THIS DOES FIBONACCI MATHS */
            int num3 = num0 + num1;
            Console.Write("{0} ", num0);
            return num3;
        }

        private static void SwapNumbers()
        {
            /* THIS SWAPS TWO NUMBERS */

            Console.WriteLine("Enter a number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 1 is {0}. Number 2 is {1}. Press enter to swap...", number1, number2);
            Console.ReadLine();
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Number 1 is now {0}. Number 2 is now {1}.", number1, number2);
        }

        private static void SpaceTest()
        { 
            /* THIS CHECKS ALL SPACES IN A SENTENCE */
            Console.WriteLine("Write a sentence please:");
            string org = Console.ReadLine();
            string test = org.Replace(" ", "");
            int spaces = org.Length - test.Length;
            Console.WriteLine("There are {0} spaces in this sentence.", spaces);
        }

        private static void SayHello(string v)
        {
            Console.WriteLine("Hello " + v);
        }

        private static void CheckEvenOrOdd()
        {
            /* CHECKS IF A NUMBER IS EVEN OR ODD*/

            Console.WriteLine("Input a number:");
            int check = int.Parse(Console.ReadLine());
            if(check % 2 == 0)
            {
                Console.WriteLine("this is an even number");
            }
            else
            {
                Console.WriteLine("this is not even");
            }
           
        }

        private static void DoMath()
        {
            /* THIS DOES MATH */

            Console.WriteLine("What do you want to do? \n add - subtract - divide - multiply - addmany");
            string action = Console.ReadLine().ToLower().Trim();

            int? number3;
            switch (action)
            {
                case "add":
                    Console.WriteLine("Type first number:");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number:");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    number3 = number1 + number2;
                    Console.WriteLine("Answer is {0}", number3);
                    break;
                case "subtract":
                    Console.WriteLine("Type first number:");
                    number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number:");
                    number2 = Convert.ToInt32(Console.ReadLine());

                    number3 = number1 - number2;
                    Console.WriteLine("Answer is {0}", number3);
                    break;

                case "divide":
                    Console.WriteLine("Type first number:");
                    number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number:");
                    number2 = Convert.ToInt32(Console.ReadLine());

                    number3 = number1 / number2;
                    Console.WriteLine("Answer is {0}", number3);
                    break;

                case "multiply":
                    Console.WriteLine("Type first number:");
                    number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number:");
                    number2 = Convert.ToInt32(Console.ReadLine());

                    number3 = number1 * number2;
                    Console.WriteLine("Answer is {0}", number3);
                    break;
                case "addmany":

                    Console.WriteLine("How many numbers do you want to add?");
                    int num = int.Parse(Console.ReadLine());
                    int[] arr = new int[num];

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine("Type number {0}:", i+1);
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    number3 = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        number3 += arr[i];
                    }
                    Console.WriteLine("Answer is {0}", number3);
                    break;

                default:
                    Console.WriteLine("Fuck you. Press enter to exit...");
                    Console.ReadLine();
                    break;
            }
        }
        
        private static void MakePyramid()
        {
            /* THIS MAKES A PYRAMID */
            Console.WriteLine("Enter number you want as a pyramid");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number to determine size of pyramid");
            int size = int.Parse(Console.ReadLine());

            for(int i = size; i>0; i--)
            {
                string output = "";
                for(int j = 1; j<=i; j++)
                {
                    output = output + number;
                }
                Console.WriteLine(output);
                
                /* IT'S REALLY MORE LIKE A TRIANGLE BUT THE EXERCISE SAID PYRAMID */
            }
        }
    }
}