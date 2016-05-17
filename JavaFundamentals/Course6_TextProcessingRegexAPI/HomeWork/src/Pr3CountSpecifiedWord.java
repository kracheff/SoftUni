import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 07.04.2016.
 */
public class Pr3CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine().toLowerCase();
        String targetWord = sc.nextLine().toLowerCase();

        int wordCounter = 0;

        String[] words = input.split("[^a-zA-Z]+");

        for (int i = 0; i < words.length; i++) {
            if(words[i].equals(targetWord)){
                wordCounter++;
            }
        }

        System.out.println(wordCounter);
    }
}
