import java.util.ArrayList;
import java.util.Scanner;

public class OddEvenPairs {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine();
        String[] elements = str.split(" ");

        if (elements.length % 2 == 1) {
            System.out.println("Invalid length");
        }
        else {
            int[] numbers = new int[elements.length];

            for (int i = 0; i < elements.length; i++) {
                numbers[i] = Integer.parseInt(elements[i]);
            }

            for (int i = 0; i < numbers.length; i+=2) {
                if (numbers[i] % 2 == 0 && numbers[i+1] % 2 == 0) {
                    System.out.println(numbers[i] + ", " + numbers[i+1] + " -> both are even");
                }
                else if (numbers[i] % 2 == 1 && numbers[i+1] % 2 == 1) {
                    System.out.println(numbers[i] + ", " + numbers[i+1] + " -> both are odd");

                }
                else{
                    System.out.println(numbers[i] + ", " + numbers[i+1] + " -> different");
                }
            }
        }
    }
}
