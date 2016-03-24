import java.util.Scanner;

public class CharacterMultiplier {
    public static int output (String firstString, String secondString){
        int sum = 0;
        String maxString = "";

        int maxLength = Math.max(firstString.length(), secondString.length());
        int minLength = Math.min(firstString.length(), secondString.length());

        if (firstString.length() >= secondString.length()) {
            maxString = firstString;
        }
        else {
            maxString = secondString;
        }
        for (int i = 0; i < maxLength; i++) {
            if (i < minLength){
                sum += firstString.charAt(i) * secondString.charAt(i);
            }
            else {
                sum += maxString.charAt(i);
            }
        }
        return sum;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String str1 = sc.next();
        String str2 = sc.next();

        System.out.println(output(str1, str2));
    }
}
