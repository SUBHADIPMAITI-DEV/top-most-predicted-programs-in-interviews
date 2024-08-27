using System;

struct Point {
    public int x, y;
}

class StructuresExample {
    static void Main(string[] args) {
        Point p = new Point();
        p.x = 10;
        p.y = 20;
        Console.WriteLine(p.x + " " + p.y);
    }
}
