import java.util.Scanner;

/**
 * Created by user on 30.03.2016.
 */
public class Pr3LongestSequence {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        String longestSymbol = input[0];
        int longestSequence = 1;
        int counter = 1;

        for (int i = 0; i < input.length - 1; i++) {
            if (input[i].equals(input[i+1])) {
                counter++;
                if (counter > longestSequence) {
                    longestSequence = counter;
                    longestSymbol = input[i];
                }
            }else {
                counter = 1;
            }
        }
        for (int i = 0; i < longestSequence; i++) {
            if(i != longestSequence - 1) {
                System.out.print(longestSymbol + " ");
            }else{
                System.out.print(longestSymbol);
            }
        }
    }
}
