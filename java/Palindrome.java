public class Palindrome {
    public static void main(String[] args) {
        String s = "radar";
        System.out.println(isPalindrome(s));
    }

    public static boolean isPalindrome(String s) {
        int len = s.length();
        for (int i = 0; i < len / 2; i++) {
            if (s.charAt(i) != s.charAt(len - i - 1)) {
                return false;
            }
        }
        return true;
    }
}
