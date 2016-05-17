import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

/**
 * Created by user on 07.04.2016.
 */
public class Pr7MagicExchangeableWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        String first = input[0];
        String second = input[1];

        Boolean result = true;

        Map<Character, Character> values = new HashMap<>();

        for (int i = 0; i < first.length(); i++) {
            if(values.get(first.charAt(i))== null){
                values.put(first.charAt(i), second.charAt(i));
            }
            if(values.get(first.charAt(i)) != second.charAt(i)){
                result = false;
            }
        }
        System.out.println(result);
    }
}
