using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_x_n
{
    /// <summary>
    /// This class demonstrates how to calculate x raised to the power n using Divide & Conquer algorithm
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double result;
            int num, exponent;

            // Test 1
            num = 2;
            exponent = 3;
            result = calcPower(num, exponent); // result should be 8
            PrintResult(num, exponent, result);

            // Test 2
            num = 2;
            exponent = 25;
            result = calcPower(num, exponent); // result should be 33,554,432
            PrintResult(num, exponent, result);

            // Test 3
            num = 5;
            exponent = 7;
            result = calcPower(num, exponent); // result should be 78125
            PrintResult(num, exponent, result);

            // Test 4
            num = 10;
            exponent = 10;
            result = calcPower(num, exponent); // result should be 10,000,000,000
            PrintResult(num, exponent, result);

            Console.Read();
        }

        /// <summary>
        /// Function to calculate x raised to the power n using Divide & Conquer algorithm.
        /// It is optimized to O(log n)
        /// </summary>
        /// <param name="num">A number</param>
        /// <param name="exponent">An Exponent</param>
        /// <returns>Result of x raised to the power n</returns>
        private static double calcPower(int num, int exponent)
        {
            if (exponent == 0)
                return 1;

            double tempValue = calcPower(num, exponent / 2);

            if (exponent % 2 == 0)
                return tempValue * tempValue;
            else
                return num * tempValue * tempValue;
        }

        /// <summary>
        /// This method prints the result on the Console
        /// </summary>
        /// <param name="num">A Number</param>
        /// <param name="exponent">An Exponent</param>
        /// <param name="result">Result of x raised to the power n</param>
        private static void PrintResult(int num, int exponent, double result)
        {
            Console.WriteLine($"{num} raised to the power {exponent} = {result}.");
        }
    }
}
