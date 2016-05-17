import java.util.Scanner;

/**
 * Created by user on 07.04.2016.
 */
public class Pr6StartsEndsWithCapitalLetters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        String regex = "^[A-Z][a-zA-Z]*[A-Z]$";

        String output = "";

        for (String s : input) {
            if(s.matches(regex)){
                output += s + " ";
            }
        }
        System.out.println(output.trim());
    }
}
