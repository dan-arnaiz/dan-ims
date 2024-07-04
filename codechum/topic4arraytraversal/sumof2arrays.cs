using System;

class MainClass {
    static public void Main() {
        Console.Write("Enter the size of the arrays: ");
        int size = int.Parse(Console.ReadLine());
        int[] array1 = new int[size];
        int[] array2 = new int[size];
        int[] sum = new int[size];

        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < size; i++) {
            Console.Write($"Enter element #{i + 1}: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < size; i++) {
            Console.Write($"Enter element #{i + 1}: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < size; i++) {
            sum[i] = array1[i] + array2[i];
            Console.WriteLine($"{array1[i]} + {array2[i]} = {sum[i]}");
        }
    }
}