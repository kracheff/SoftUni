import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 07.04.2016.
 */
public class Pr2SubstringOccurrences {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String text = sc.nextLine().toLowerCase();
        String substring = sc.nextLine().toLowerCase();
        int matchCounter = 0;

        for (int i = 0; i < text.length(); i++) {
            if(i + substring.length() > text.length()){
                break;
            }
            if(substring.equals(text.substring(i, i + substring.length()))){
                matchCounter++;
            }
        }

//        Pattern regex = Pattern.compile(substring);
//        Matcher matcher = regex.matcher(text);
//
//        while (matcher.find()){
//            matchCounter++;
//        }
//
        System.out.println(matchCounter);
    }
}
