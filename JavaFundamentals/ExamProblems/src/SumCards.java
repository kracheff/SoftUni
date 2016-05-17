import java.util.Scanner;

/**
 * Created by user on 17.04.2016.
 */
public class SumCards {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        int[] numbers = new int[input.length];

        for (int i = 0; i < input.length; i++) {
            switch (input[i].substring(0, input[i].length() - 1)) {
                case "J":
                    numbers[i] = 12;
                    break;
                case "Q":
                    numbers[i] = 13;
                    break;
                case "K":
                    numbers[i] = 14;
                    break;
                case "A":
                    numbers[i] = 15;
                    break;
                default:
                    numbers[i] = Integer.parseInt(input[i].substring(0, input[i].length() - 1));
                    break;
            }
        }

        int sum = 0;
        int subsequence = numbers[0];
        int counter = 0;

        for (int i = 0; i < numbers.length; i++) {
            if(i != numbers.length - 1) {
                if (numbers[i] == numbers[i + 1]) {
                    subsequence += numbers[i + 1];
                    counter++;
                } else {
                    if (counter == 0) {
                        sum += numbers[i];
                        subsequence = numbers[i + 1];
                    } else {
                        sum += subsequence * 2;
                        subsequence = numbers[i + 1];
                        counter = 0;
                    }
                }
            }else{
                if(numbers.length == 1 || numbers[i] != numbers[i - 1]){
                    sum += numbers[i];
                }else{
                    sum += subsequence * 2;
                }
            }
        }
        System.out.println(sum);
    }
}
