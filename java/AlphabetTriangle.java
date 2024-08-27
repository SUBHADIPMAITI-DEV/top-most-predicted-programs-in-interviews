public class AlphabetTriangle {
    public static void main(String[] args) {
        int n = 5;
        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                System.out.print(" ");
            }
            for (int j = 0; j <= i; j++) {
                System.out.print(alphabet.charAt(j));
            }
            System.out.println();
        }
    }
}
