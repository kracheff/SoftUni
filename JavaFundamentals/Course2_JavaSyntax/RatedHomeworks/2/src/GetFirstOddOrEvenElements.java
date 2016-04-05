import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class GetFirstOddOrEvenElements {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] numbersAsString = scan.nextLine().split(" ");
        String[] input = scan.nextLine().split(" ");
        int count = Integer.parseInt(input[1]);
        String command = input[2];

        int[] numbers = new int[numbersAsString.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsString[i]);
        }
        if (command.equals("odd")) {
            collectNumbers(numbers, count, 1);
        } else {
            collectNumbers(numbers, count, 0);
        }

    }

    private static void collectNumbers(int[] numbers, int count, int command) {
        for (int i = 0; i < numbers.length; i++) {
            if (count == 0) {
                break;
            }
            if (numbers[i] % 2 == command) {
                count--;
                System.out.print(numbers[i] + " ");
            }
        }
    }
}
