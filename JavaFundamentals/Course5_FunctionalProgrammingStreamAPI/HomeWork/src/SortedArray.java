import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by user on 04.04.2016.
 */
public class SortedArray {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        String sortingOrder = sc.nextLine();
        Integer[] numbers = new Integer[input.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }
        if (sortingOrder.equals("Descending")) {

            Arrays.stream(numbers).sorted((f1, f2) -> f2.compareTo(f1)).forEach(e -> System.out.print(e + " "));
        }else{
            Arrays.stream(numbers).sorted((f1, f2) -> f1.compareTo(f2)).forEach(e -> System.out.print(e + " "));

        }
    }
}
