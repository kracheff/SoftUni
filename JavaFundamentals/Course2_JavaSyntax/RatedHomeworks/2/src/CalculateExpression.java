import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class CalculateExpression {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        double a = input.nextDouble();
        double b = input.nextDouble();
        double c = input.nextDouble();

        double expr1 = (((a * a) + (b * b)) / ((a * a) - (b * b)));
        double power1 = (a + b + c) / Math.sqrt(c);
        double resultF1 = Math.pow(expr1, power1);


        double expr2 = ((a * a) + (b * b) - (c * c * c));
        double power2 = a - b;
        double resultF2 = Math.pow(expr2, power2);

        double avg1 = (a + b + c) / 3.0;
        double avg2 = (resultF1 + resultF2) / 2;
        double diff = Math.abs(avg1 - avg2);
        // output
        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", resultF1, resultF2, diff);
    }
}
