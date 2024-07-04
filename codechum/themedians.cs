using System;

class MainClass {
    static public void Main() {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < size; i++) {
            array[i] = int.Parse(Console.ReadLine());
        }

        if (size % 2 == 0) {
            // For even-sized array, print the two middle elements
            Console.WriteLine($"Medians: {array[size / 2 - 1]} and {array[size / 2]}");
        } else {
            // For odd-sized array, print the middle element
            Console.WriteLine($"Median: {array[size / 2]}");
        }
    }
}