using System;
namespace assigment_5
{
    internal class Program
    {
        static void swap1(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void swap2(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int sumarray(int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static int sumarray2(ref int[] arr)
        {
            int sum = 0;
            if (arr != null)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static void sumsub(int x, int y, int w, int z, out int sum, out int sub)
        {
            sum = x + y;
            sub = w - z;
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            min = array[0];
            max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                else if (array[i] > max)
                    max = array[i];
            }
            static long Factorial(int number)
            {
                long result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }
        }
        static void Main(string[] args)
        {

            #region 1.question 1
            ////Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            #region passing by value
            int a = 10, b = 20;
            Console.WriteLine("a  " + a);
            Console.WriteLine("b  " + b);
            Console.WriteLine("swap");
            swap2(a, b);
            Console.WriteLine("a  " + a);
            Console.WriteLine("b  " + b);
            #endregion
            #region passing by reference 
            int c = 10, d = 20;
            Console.WriteLine("a  " + c);
            Console.WriteLine("b  " + d);
            Console.WriteLine("swap");
            swap1(ref c, ref d);
            Console.WriteLine("a  " + c);
            Console.WriteLine("b  " + d);
            #endregion
            #endregion
            #region 2.question 2
            ////Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            #region passing by value
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[0]);
            int result = sumarray(numbers);
            Console.WriteLine(result);
            Console.WriteLine(numbers[0]);
            #endregion
            #region passing by reference
            int[] number = { 1, 2, 3 };
            Console.WriteLine(numbers[0]);
            int results = sumarray2(ref number);
            Console.WriteLine(results);
            Console.WriteLine(number[0]);

            #endregion
            #endregion
            #region 3.question3
           // Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            int a = 10, b = 20, c = 60, d = 50;
            int sumresult, subresult;
            sumsub(a, b, c, d, out sumresult, out subresult);
            Console.WriteLine(sumresult);
            Console.WriteLine(subresult);
            #endregion
            #region 4.question 4
            //Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            Console.Write("plese Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = SumOfDigits(number);

            Console.WriteLine(sum);

            #endregion
            #region 6.question 6
            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            int[] array = { 12, 45, 7, 23, 56, 89, 34 };

            int min, max;
            MinMaxArray(array, ref min, ref max);

            Console.WriteLine(min);
            Console.WriteLine(max);
            #endregion
            #region 7.question 7
            //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = Factorial(number);

            Console.WriteLine(factorial);
            #endregion

        }


    }
}
