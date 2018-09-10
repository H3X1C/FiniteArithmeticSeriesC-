using System;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of finite arithmetic series");

            // Array declaration and definition
            int[] numberArray = new int[5];
            numberArray[0] = 1;
            numberArray[1] = 2;
            numberArray[2] = 3;
            numberArray[3] = 4;
            numberArray[4] = 5;

            // Print out array
            Console.WriteLine( "Array Elements: [{0}]", string.Join(", ", numberArray) );
            // Print out length of array
            Console.WriteLine("Array Length: " + numberArray.Length);

            // Call static function passing our array, returns sum
            int result = CalculateArraySum(numberArray.Length);

            // Print out result
            Console.WriteLine("Array Sum: " + result);

            Console.Write("\n\n");

            Console.WriteLine("Missing number in sum of finite arithmetic series");

            // Array declaration and definition
            int[] numberArray2 = new int[9];
            numberArray2[0] = 1;
            numberArray2[1] = 2;
            numberArray2[3] = 4;
            numberArray2[4] = 5;
            numberArray2[5] = 6;
            numberArray2[6] = 7;
            numberArray2[7] = 8;
            numberArray2[8] = 9;

            // Print out array
            Console.WriteLine("Array Elements: [{0}]", string.Join(", ", numberArray2));
            // Print out length of array
            Console.WriteLine("Array Length: " + numberArray2.Length);

            // Call static function passing details
            int calcSum = CalculateArraySum(numberArray2.Length);
            int actSum = SumActualArray(numberArray2);
            int missingELement = IdentifyMissingElement(calcSum, actSum);

            // Print out results
            Console.WriteLine("Calculated Array Sum: " + calcSum);
            Console.WriteLine("Actual Array Sum: " + actSum);
            Console.WriteLine("Missing element: " + missingELement );

            // Console waits for read line
            Console.ReadLine();

        }

        public static int CalculateArraySum(int arrayLength)
        {
            float result = ((float)arrayLength / 2) * ((float)arrayLength + 1);
            return (int)result;
        }

        public static int SumActualArray(int[] numberArray)
        {
            int actualSum = 0;
            foreach (int i in numberArray)
            {
                actualSum += i;
            }
            return actualSum;
        }

        public static int IdentifyMissingElement(int calculatedSum, int actualSum)
        {
            return calculatedSum-actualSum;
        }
    }
}
