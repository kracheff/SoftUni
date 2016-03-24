import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        double b = Double.parseDouble(sc.next());
        double c = Double.parseDouble(sc.next());

        String aToBinary = Integer.toBinaryString(a);
        String aToBinaryLeftPadded = "0000000000".substring(aToBinary.length()) + aToBinary;

        System.out.printf("|%1$-10X|%2$10s|%3$10.2f|%4$-10.3f|", a, aToBinaryLeftPadded, b, c);
    }
}
