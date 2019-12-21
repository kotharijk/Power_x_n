using System;

namespace Power_x_n
{
    /// <summary>
    /// This class demonstrates how to calculate x raised to the power n using an algorithm optimized for optimized for O(log n)
    /// </summary>
    class Program
    {
        /// <summary>
        /// This is the Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            decimal result, num;
            int exponent;

            // Test 1
            num = 2;
            exponent = 10;
            result = calcPower(num, exponent); // result should be 1024
            PrintResult(num, exponent, result);

            // Test 2
            num = 3.5M;
            exponent = 15;
            result = calcPower(num, exponent); // result should be 144,884,079.282928466796875
            PrintResult(num, exponent, result);


            // Test 3
            num = 2;
            exponent = 50;
            result = calcPower(num, exponent); // result should be 1,125,899,906,842,624
            PrintResult(num, exponent, result);

            // Test 3
            num = 5.5M;
            exponent = 15;
            result = calcPower(num, exponent); // result should be 127,479,497,357.655364990234375
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
        /// It is optimized for O(log n)
        /// </summary>
        /// <param name="num">A decimal value</param>
        /// <param name="exponent">An integer value</param>
        /// <returns>Result of num raised to the power exponent</returns>
        private static decimal calcPower(decimal num, int exponent)
        {
            if (exponent == 0)
                return 1;

            decimal tempValue = calcPower(num, exponent / 2);

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
        private static void PrintResult(decimal num, int exponent, decimal result)
        {
            Console.WriteLine($"{num} raised to the power {exponent} = {result}");
        }
    }
}
