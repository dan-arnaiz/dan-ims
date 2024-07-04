
using System;

class MainClass {
    static public void Main() {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int sum = 0;

        for (int i = 0; i < size; i++) {
            Console.Write($"Enter element #{i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }

        double average = (double)sum / size;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
    }
}