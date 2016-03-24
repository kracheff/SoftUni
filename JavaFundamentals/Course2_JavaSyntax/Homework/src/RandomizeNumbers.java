import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int m = sc.nextInt();

        int minInt = Math.min(n, m);
        int maxInt = Math.max(n, m);

        int[] randomized = new int[maxInt - minInt + 1];
        Random rnd = new Random();
        int counter = 0;

        for (int j = 0; j < randomized.length; j++) {
            counter = 0;
            int nextRnd = ThreadLocalRandom.current().nextInt(minInt, maxInt + 1);

            for (int i = 0; i < randomized.length; i++) {

                if(nextRnd == randomized[i]){
                    counter++;
                }
                else {
                    continue;
                }
            }
            if (counter > 0){
                j -= 1;
            }
            else {
                randomized[j] = nextRnd;
            }
        }
        System.out.println(Arrays.toString(randomized));
    }
}
