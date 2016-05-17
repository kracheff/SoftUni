import java.util.Scanner;

/**
 * Created by user on 07.04.2016.
 */
public class Pr4CountAllWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] words = input.split("[^a-zA-Z]+");
        System.out.println(words.length);
    }
}
