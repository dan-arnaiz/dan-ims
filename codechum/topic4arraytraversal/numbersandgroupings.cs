
using System;
using System.Collections.Generic;

class MainClass {
    static public void Main() {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < size; i++) {
            Console.Write($"Enter element #{i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
            if (array[i] % 2 == 0) {
                evenNumbers.Add(array[i]);
            } else {
                oddNumbers.Add(array[i]);
            }
        }

        Console.WriteLine($"Even: {string.Join(", ", evenNumbers)}");
        Console.WriteLine($"Odd: {string.Join(", ", oddNumbers)}");
    }
}