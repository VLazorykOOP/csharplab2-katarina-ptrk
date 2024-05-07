//v10
namespace Lab2CSharp
{

    internal class Program
    {

        static int CountNotInInterval(int[] array, int lowerBound, int upperBound)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num < lowerBound || num > upperBound)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountNotInInterval(int[,] array, int lowerBound, int upperBound)
        {
            int count = 0;
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[i, j] < lowerBound || array[i, j] > upperBound)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void PrintArray(int[,] array)
        {
            int size = array.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void task1()
        {
            Console.WriteLine("Task 1.10: Count elements not falling within a specified interval");

            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] oneDimArray = new int[size];
            int[,] twoDimArray = new int[size, size];

            Console.WriteLine("How to fill array? (1 - manually, 2 - random)");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Input 1d[{i}]: ");
                    oneDimArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write($"Input 2d[{i}][{j}]: ");
                        twoDimArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

            }
            else
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    oneDimArray[i] = random.Next(100);
                    for (int j = 0; j < size; j++)
                    {
                        twoDimArray[i, j] = random.Next(100);
                    }
                }
            }

            Console.WriteLine("Enter the lower bound of the interval:");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the interval:");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("One-dimensional array:");
            PrintArray(oneDimArray);
            int countNotInInterval1D = CountNotInInterval(oneDimArray, lowerBound, upperBound);
            Console.WriteLine($"Number of elements not in the interval [{lowerBound}, {upperBound}]: {countNotInInterval1D}");

            Console.WriteLine("Two-dimensional array:");
            PrintArray(twoDimArray);
            int countNotInInterval2D = CountNotInInterval(twoDimArray, lowerBound, upperBound);
            Console.WriteLine($"Number of elements not in the interval [{lowerBound}, {upperBound}]: {countNotInInterval2D}");
        }

        static void task2()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("How to fill array? (1 - manually, 2 - random)");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine($"Enter {size} integers:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Input array[{i}]: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
                {
                    array[i] = random.Next(100);
                }
            }

            int min = array[0];
            int lastIndex = 0;
            for (int i = 1; i < size; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                    lastIndex = i;
                }
            }


            Console.WriteLine($"The index of the last occurrence of the minimum element ({min}) is: {lastIndex}");
        }

        static void task3() {
            Console.WriteLine("Enter the size of the matrix (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("How to fill array? (1 - manually, 2 - random)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine($"Enter the elements of the {n}x{n} matrix:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            else
            {
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = random.Next(100);
                    }
                }
            }


            int[,] poweredMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    poweredMatrix[i, j] = (int)Math.Pow(matrix[i, j], n);
                }
            }

            // Display the resulting powered matrix
            Console.WriteLine($"Matrix raised to the power of {n}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(poweredMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void task4() {
            Console.WriteLine("Enter the number of rows (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[n][];

            Console.WriteLine("How to fill array? (1 - manually, 2 - random)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter the number of elements in row {i + 1}:");
                    int m = Convert.ToInt32(Console.ReadLine());
                    array[i] = new int[m];

                    Console.WriteLine($"Enter {m} elements for row {i + 1}:");
                    for (int j = 0; j < m; j++)
                    {
                        array[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            else
            {
                Random random = new Random();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter the number of elements in row {i + 1}:");
                    int m = Convert.ToInt32(Console.ReadLine());
                    array[i] = new int[m];

                    for (int j = 0; j < m; j++)
                    {
                        array[i][j] = random.Next(100);
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("Enter the starting index (k1) of the range:");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending index (k2) of the range:");
            int k2 = Convert.ToInt32(Console.ReadLine());

            int[] sums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = k1; j <= k2 && j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                sums[i] = sum;
            }

            Console.WriteLine("Sums for each row within the range:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Row {i + 1}: {sums[i]}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 CSharp");
            task1();
            task2();
            task3();
            task4();
        }
    }
}
