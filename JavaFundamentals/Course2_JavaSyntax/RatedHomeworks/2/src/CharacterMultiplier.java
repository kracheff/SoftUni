import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String str1 = input.next("\\w+");
        String str2 = input.next("\\w+");

        System.out.println(characterMultiplier(str1, str2));
    }

    static int characterMultiplier(String str1, String str2) {
        int result = 0;
        if (str1.length() == str2.length()) {
            for (int i = 0; i < str1.length(); i++) {
                result += str1.charAt(i) * str2.charAt(i);
            }
        } else if (str1.length() > str2.length()) {
            for (int i = 0; i < str2.length() ; i++) {
                result+= str1.charAt(i) * str2.charAt(i);
            }
            for (int i = str2.length() ; i < str1.length() ; i++) {
                result+= str1.charAt(i);
            }

        }else {
            for (int i = 0; i < str1.length() ; i++) {
                result+= str1.charAt(i) * str2.charAt(i);
            }
            for (int i = str1.length() ; i < str2.length() ; i++) {
                result+= str2.charAt(i);
            }
        }
        return result;
    }
}
