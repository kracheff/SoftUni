import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int m = input.nextInt();
        int startNumber = Math.min(n, m);
        int endNumber = Math.max(n, m);
        ArrayList<Integer> numbersList = new ArrayList<Integer>();

        for (int i = startNumber, j = 0; i <= endNumber; i++, j++){
            numbersList.add(i);
        }
        Collections.shuffle(numbersList);
        System.out.print(numbersList.toString().replaceAll("[\\[,\\]]+", ""));
    }
}
