import java.util.Scanner;

/**
 * Created by user on 30.03.2016.
 */
public class Pr6CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String specifiedWord = sc.nextLine().toLowerCase();
        int counter = 0;

        String[] words = input.split("[^a-zA-Z]+");

        for (int i = 0; i < words.length; i++) {
            if(words[i].toLowerCase().equals(specifiedWord)){
                counter++;
            }
        }
        System.out.println(counter);
    }
}
