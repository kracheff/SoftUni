import java.util.*;

/**
 * Created by user on 30.03.2016.
 */
public class Pr8UniqueWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        String[] words = input.split("[^a-zA-Z]+");

        for (int i = 0; i < words.length; i++) {
            words[i] = words[i].toLowerCase();
        }

        List<String> list = Arrays.asList(words);

        Set<String> uniqueWords = new HashSet<>(list);

        for (String uniqueWord : uniqueWords) {
            System.out.print(uniqueWord + " ");
        }
    }
}
