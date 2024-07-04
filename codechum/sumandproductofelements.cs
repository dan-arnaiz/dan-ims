
using System;

class MainClass {
    static public void Main() {
        // Input for the first array
        Console.Write("Enter size of the first array: ");
        int sizeFirst = int.Parse(Console.ReadLine());
        int[] firstArray = new int[sizeFirst];
        Console.WriteLine("Enter elements of the first array:");
        for (int i = 0; i < sizeFirst; i++) {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        // Input for the second array
        Console.Write("Enter size of the second array: ");
        int sizeSecond = int.Parse(Console.ReadLine());
        int[] secondArray = new int[sizeSecond];
        Console.WriteLine("Enter elements of the second array:");
        for (int i = 0; i < sizeSecond; i++) {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        // Calculating sum and product
        int sum = firstArray[0] + secondArray[sizeSecond - 1];
        int product = firstArray[1] * secondArray[sizeSecond - 2];

        // Output
        Console.WriteLine($"Sum of first and last: {sum}");
        Console.WriteLine($"Product of second and second to the last: {product}");
    }
}