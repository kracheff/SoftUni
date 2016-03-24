import java.util.Scanner;
import java.util.regex.Matcher;

public class Base7ToDecimal {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.next();
        int result = 0;

        for (int i = 0; i < input.length(); i++) {
            result += Integer.parseInt(input.charAt(i) + "") * Math.pow(7, input.length() - i - 1);
        }

        System.out.println(result);
    }
}
