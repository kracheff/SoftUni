import java.math.BigInteger;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 06.05.2016.
 */
public class SoftuniNumerals {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        Pattern p = Pattern.compile("(aa)|(aba)|(bcc)|(cc)|(cdc)");
        Matcher m = p.matcher(input);
        String textToNumber = "";

        while (m.find()) {                      // what if a string starts with "aa" i.e. number starts with 0
            if (m.group(1) != null) {
                textToNumber += "0";
            }
            if (m.group(2) != null) {
                textToNumber += "1";
            }
            if (m.group(3) != null) {
                textToNumber += "2";
            }
            if (m.group(4) != null) {
                textToNumber += "3";
            }
            if (m.group(5) != null) {
                textToNumber += "4";
            }
        }
        BigInteger decimalNumber = BigInteger.ZERO;
        BigInteger newNumber = BigInteger.ZERO;

        for (int i = 0; i < textToNumber.length(); i++) {
            BigInteger charAtPos = BigInteger.valueOf((Long.parseLong(String.valueOf(textToNumber.charAt(i)))));
            BigInteger powerOfFive = BigInteger.valueOf(5).pow(textToNumber.length() - i - 1);
            BigInteger multiply = charAtPos.multiply(powerOfFive);
            newNumber = decimalNumber.add(multiply);
            decimalNumber = newNumber;
        }
        System.out.println(newNumber);
    }
}
