import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class ConvertFromBase7ToDec {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int a = Integer.parseInt(input.nextLine(), 7);
        System.out.printf(Integer.toString(a, 10));
    }
}
