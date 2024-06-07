namespace CSI120_Assignment_Array
{
    internal class Program
    {
        // Hoang Khoi Gia Nguyen
        // CSI 120 - Computer Programming 1
        // Assignment - Arrays

        static double[] arrayAssignment; // Declare array

        static void Main(string[] args)
        {
            // Inputting size of array
            Console.Write("Enter size of array: ");
            int arraySize = int.Parse(Console.ReadLine());

            arrayAssignment = new double[arraySize];
            Random randomizer = new Random();

            for (int i = 0; i < arraySize; i++) // Assign random value to elements in the array
            {
                arrayAssignment[i] = randomizer.Next(1, 101);

            }

            

            double arraySum = 0; // Calculate sum

            for (int i = 0; i < arraySize; i++)
            {
                arraySum += arrayAssignment[i];
            }


            double arrayAverage = arraySum / arraySize; // Calculate average


            double arrayLargest = arrayAssignment.Max(); // Locate largest number/max value


            double arraySmallest = arrayAssignment.Min(); // Locate smallest number/min value

            // Counting value for counting amount of even/odd numbers
            int evenCount = 0;
            int oddCount = 0;

            for (int i = 0; i < arraySize; i++)
            {
                if (arrayAssignment[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            // Printing out results
            Console.Write("The elements in the array are: ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(arrayAssignment[i]);
                if (i != arraySize - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of the array elements: {arraySum}");
            Console.WriteLine($"The average of the array elements: {arrayAverage}");
            Console.WriteLine($"The largest number in the array: {arrayLargest}");
            Console.WriteLine($"The smallest number in the array: {arraySmallest}");
            Console.WriteLine($"There are {evenCount} even number(s) in the array.");
            Console.WriteLine($"There are {oddCount} odd number(s) in the array.");


        }// Main



    }// Class

}// Name
