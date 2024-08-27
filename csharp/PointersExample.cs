//C# supports pointers, but they require unsafe code blocks.

using System;

class PointersExample {
    unsafe static void Main(string[] args) {
        int a = 10;
        int* p = &a;
        modifyPointer(p);
        Console.WriteLine(a);
    }

    unsafe static void modifyPointer(int* p) {
        *p = 100;
    }
}
