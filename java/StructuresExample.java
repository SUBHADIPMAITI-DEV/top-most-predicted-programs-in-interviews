//Java uses classes instead of structures.

class Point {
    int x, y;
    Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
}

public class StructuresExample {
    public static void main(String[] args) {
        Point p = new Point(10, 20);
        System.out.println(p.x + " " + p.y);
    }
}
