//Java doesn't support pointers, but reference variables can be used similarly.

public class PointersExample {
    public static void main(String[] args) {
        int[] arr = {1, 2, 3};
        modifyArray(arr);
        System.out.println(arr[0]);
    }

    public static void modifyArray(int[] arr) {
        arr[0] = 100;
    }
}
