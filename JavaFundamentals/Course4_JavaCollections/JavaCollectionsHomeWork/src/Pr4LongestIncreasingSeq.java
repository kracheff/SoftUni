import java.util.Scanner;

/**
 * Created by user on 30.03.2016.
 */
public class Pr4LongestIncreasingSeq {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        int[] numbers = new int[input.length];

        for (int i = 0; i < input.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }
        int[] longestArray = {numbers[0]};
        int longestSequence = 1;
        int counter = 1;

        System.out.print(numbers[0]);

        for (int i = 0; i < numbers.length - 1; i++) {
            if(numbers[i] < numbers [i + 1]){
                System.out.print(" " + numbers[i + 1]);
                counter++;
                if(counter > longestSequence){
                    longestSequence = counter;
                    longestArray = new int[longestSequence];
                    for (int j = 0; j < longestSequence; j++) {
                        longestArray[j] = numbers[i - longestSequence + j + 2];
                    }
                }
            }else{
                System.out.println();
                System.out.print(numbers[i + 1]);
                counter = 1;
            }
        }
        System.out.println();
        System.out.print("Longest: ");
        for (int i = 0; i < longestArray.length; i++) {
            System.out.print(longestArray[i] + " ");
        }
    }
}
