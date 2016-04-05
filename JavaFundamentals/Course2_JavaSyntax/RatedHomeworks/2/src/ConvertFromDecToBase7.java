import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class ConvertFromDecToBase7 {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int a = input.nextInt();

        System.out.println(Integer.toString(a, 7));
    }
}
