public class ArmstrongNumbers {
    public static void main(String[] args) {
        for (int i = 1; i < 1000; i++) {
            if (isArmstrong(i)) {
                System.out.print(i + " ");
            }
        }
    }

    public static boolean isArmstrong(int num) {
        int sum = 0, temp = num, n = 0;
        while (temp != 0) {
            temp /= 10;
            n++;
        }
        temp = num;
        while (temp != 0) {
            int digit = temp % 10;
            sum += Math.pow(digit, n);
            temp /= 10;
        }
        return num == sum;
    }
}
