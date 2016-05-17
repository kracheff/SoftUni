import java.util.Scanner;
import java.util.regex.*;

/**
 * Created by user on 07.04.2016.
 */
public class Pr1ExtractEmails {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        String regex = "[A-Za-z0-9.\\-_]+@[A-Za-z0-9.\\-_]+\\.[A-Za-z]+[^\\.,\\- ]";

        Pattern emailPattern = Pattern.compile(regex);
        Matcher matcher = emailPattern.matcher(input);
        while (matcher.find()){
            System.out.println(matcher.group());
        }
    }
}
