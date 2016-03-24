/**
 * Created by 123 on 3/20/2016.
 */
import java.util.Scanner;

public class SumNumbersfrom1toN {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        Integer number = reader.nextInt();
        Integer sum = calculateSum(number);
        System.out.print(sum);
    }

    private static Integer calculateSum(Integer number) {
        Integer sum = 0;
        for (int i = 1; i <= number ; i++) {
            sum+=i;
        }
        return sum;
    }
}