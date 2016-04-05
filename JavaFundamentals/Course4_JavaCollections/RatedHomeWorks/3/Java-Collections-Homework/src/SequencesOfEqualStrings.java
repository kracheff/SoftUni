import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        System.out.print("Enter a single String so it can be split: ");
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] arr = input.split(" ");
        for (int i = 0; i < arr.length; i++) {
            int count = 1;
            for (int j = i + 1; j < arr.length; j++) {
                if (arr[j].equals(arr[i])){
                    count++;
                }
                else {
                    break;
                }
            }

            for (int j = i; j < i + count; j++) {
                System.out.print(arr[j] + " ");
            }
            System.out.println();
            if (count > 1){
                i += count - 1;
            }

        }
    }
}
