import java.util.Scanner;

/**
 * Created by user on 30.03.2016.
 */
public class Pr5CountWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] words = input.split("[^a-zA-Z]+");
        System.out.println(words.length);
    }
}
