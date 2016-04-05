import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by user on 04.04.2016.
 */
public class FilterArray {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        Arrays.stream(input).filter(s -> s.length() > 3).forEach(w -> System.out.print(w + " "));
    }
}
