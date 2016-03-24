import java.util.Scanner;

/**
 * Created by user on 19.03.2016.
 */
public class GetAverage {

    public static double calculateAverage(double a, double b, double c){
        return (a + b + c) / 3;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double firstNumber = sc.nextDouble();
        double secondNumber = sc.nextDouble();
        double thirdNumber = sc.nextDouble();

        double average = calculateAverage(firstNumber, secondNumber, thirdNumber);

        System.out.printf("Average of three numbers is %.2f\n", average);
    }
}
