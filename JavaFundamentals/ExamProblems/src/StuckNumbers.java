import java.util.LinkedList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 15.04.2016.
 */
public class StuckNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        String[] input = sc.nextLine().split(" ");

        LinkedList<String> allCombinations = new LinkedList<>();
        LinkedList<String> matchingNumbers = new LinkedList<>();


        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i == j) {
                    continue;
                }
                allCombinations.add(input[i] + "|" + input[j]);
                matchingNumbers.add(input[i] + input[j]);
            }
        }
        int counter = 0;
        String regex = "[0-9]|[0-9]";
        for (int i = 0; i < allCombinations.size(); i++) {
            for (int j = 0; j < allCombinations.size(); j++) {
                if (i == j) {
                    continue;
                }
                if(matchingNumbers.get(i).equals(matchingNumbers.get(j))){
                    System.out.println(allCombinations.get(i) + "==" + allCombinations.get(j));
                    counter++;
                }
            }

        }
        if (counter == 0) {
            System.out.println("No");
        }
    }


}

