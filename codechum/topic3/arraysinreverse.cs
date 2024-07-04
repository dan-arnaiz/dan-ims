using System;

class MainClass {
    static public void Main() {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"Enter element at row {i}, column {j}: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = rows - 1; i >= 0; i--) {
            for (int j = cols - 1; j >= 0; j--) {
                Console.Write(array[i, j]);
                if (j > 0) {
                    Console.Write("\t");
                }
            }
            Console.WriteLine();
        }
    }
}