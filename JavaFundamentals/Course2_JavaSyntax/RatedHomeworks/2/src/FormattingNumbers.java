import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int a = input.nextInt();
        double b = input.nextDouble();
        double c = input.nextDouble();

        String aHex = Integer.toHexString(a).toUpperCase();
        String aBin = String.format("%10s", Integer.toBinaryString(a)).replace(" ", "0");

        System.out.printf("|%-10s|%s|%10.2f|%-10.3f|" , aHex, aBin, b, c);
    }
}
