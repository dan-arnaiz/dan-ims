using System;

class Program {
    public static void Hello() {
        for (int i = 0; i < 5; i++) {
            Console.WriteLine("Hello CodeChum");
        }
    }

    static void Main(string[] args) {
        Hello();
        Hello();
        Hello();
    }
}