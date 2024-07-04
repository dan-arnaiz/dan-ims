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

        Console.WriteLine("Last element: " + array[size - 1]);
    }
}