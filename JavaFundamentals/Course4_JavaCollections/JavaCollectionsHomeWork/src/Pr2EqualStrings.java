import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * Created by user on 30.03.2016.
 */
public class Pr2EqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        System.out.print(input[0]);

        for (int i = 0; i < input.length - 1; i++) {
            if (input[i].equals(input[i+1])) {
                System.out.print(" " + input[i+1]);
            }else{
                System.out.println();
                System.out.print(input[i+1]);
        }
        }
    }
}
