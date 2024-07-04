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

        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (array[i, j] == x) {
                    found = true;
                    break;
                }
            }
            if (found) break;
        }

        if (found) {
            Console.WriteLine("Found!");
        } else {
            Console.WriteLine($"Sorry, {x} not found.");
        }
    }
}