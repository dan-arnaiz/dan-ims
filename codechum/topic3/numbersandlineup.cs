using System;

class MainClass {

    static public void Main()
    {
        int[,] numArray = new int[2, 4] {{1, 2, 3, 4}, {3, 5, 7, 9}};

        // Hey there, start typing your C# code here...
        for (int i = 0; i < numArray.GetLength(0); i++) {
            for (int j = 0; j < numArray.GetLength(1); j++) {
                Console.Write(numArray[i, j]);
                if (j < numArray.GetLength(1) - 1) {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}