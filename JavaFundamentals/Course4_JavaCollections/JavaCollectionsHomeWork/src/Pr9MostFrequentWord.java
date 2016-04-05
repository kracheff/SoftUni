import java.util.*;

/**
 * Created by user on 31.03.2016.
 */
public class Pr9MostFrequentWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] words = input.split("[^a-zA-Z]+");

        for (int i = 0; i < words.length; i++) {
            words [i] = words[i].toLowerCase();
        }

        TreeMap<String, Integer> output = new TreeMap<>();

        for (String word : words) {
            Integer counter = output.get(word);

            if (counter == null) {
                counter = 0;
            }
            output.put(word, counter + 1);
        }

        //Find the maximum count
        ArrayList<Integer> temp = new ArrayList<>();
        for (Integer integer : output.values()) {
            temp.add(integer);
        }
        int max = temp.get(0);
        for (Integer integer : temp) {
            if (integer > max) {
                max = integer;
            }
        }
        // Print the output
        for (Map.Entry<String, Integer> entry : output.entrySet()) {
            if(entry.getValue() == max){
                System.out.println(entry.getKey() + " -> " + max + " times");
            }
        }
    }
}
