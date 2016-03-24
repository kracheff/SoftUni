import java.util.Locale;
import java.util.Scanner;

public class CalculateExpression {
    public static double firstFormula(double a, double b, double c){
        double result = Math.pow((a * a + b * b) / (a * a - b * b), (a + b + c) / Math.sqrt(c));

        return result;
    }

    public static double secondFormula (double a, double b, double c){
        double result = Math.pow(a * a + b * b - c * c * c, a - b);

        return result;
    }

    public static double averageOfFormulas(double a, double b, double c){
        double averageOfCalculations = (firstFormula(a, b, c) + secondFormula(a, b, c)) / 2;

        return averageOfCalculations;
    }

    public static double averageOfNumbers (double a, double b, double c){
        double average = (a + b + c) / 3;

        return average;
    }

    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();

        System.out.printf("F1 result: %1$.2f; F2 result: %2$.2f; Diff: %3$.2f",
                firstFormula(a, b, c),
                secondFormula(a, b, c),
                averageOfFormulas(a, b, c)- averageOfNumbers(a, b, c));
    }
}
