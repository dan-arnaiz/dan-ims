using System;
using System.Collections.Generic;

class MainClass {
    static public void Main() {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, cols];
        List<int> divisibleBy3 = new List<int>();
        List<int> divisibleBy5 = new List<int>();

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"Enter element at row {i}, column {j}: ");
                array[i, j] = int.Parse(Console.ReadLine());

                if (array[i, j] % 3 == 0) {
                    divisibleBy3.Add(array[i, j]);
                }
                if (array[i, j] % 5 == 0) {
                    divisibleBy5.Add(array[i, j]);
                }
            }
        }

        Console.WriteLine("Divisible by 3: " + string.Join(", ", divisibleBy3));
        Console.WriteLine("Divisible by 5: " + string.Join(", ", divisibleBy5));
    }
}