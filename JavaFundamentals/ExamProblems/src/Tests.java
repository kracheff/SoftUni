import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 21.04.2016.
 */
public class Tests {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        Pattern p = Pattern.compile("(aa)|(aba)|(bcc)|(cc)|(cdc)");
        Matcher m = p.matcher(input);
        String textToNumber = "";

        try {
            if (m.group(1) != null) {
                textToNumber += "0";
            }
        } catch (IndexOutOfBoundsException e) {
        }
        try {
            if (m.group(2) != null) {
                textToNumber += "1";
            }
        } catch (IndexOutOfBoundsException e) {
        }
        try {
            if (m.group(3) != null) {
                textToNumber += "2";
            }
        } catch (IndexOutOfBoundsException e) {
        }
        try {
            if (m.group(4) != null) {
                textToNumber += "3";
            }
        } catch (IndexOutOfBoundsException e) {
        }
        try {
            if (m.group(5) != null) {
                textToNumber += "4";
            }
        } catch (IndexOutOfBoundsException e) {
        }
    }

}

