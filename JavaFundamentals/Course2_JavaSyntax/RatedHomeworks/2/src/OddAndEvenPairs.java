import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String input = console.nextLine();
        String[] arrayAsString = input.split("\\s+");

        if ((arrayAsString.length % 2) != 0) {
            System.out.print("Invalid length");
            System.exit(0);
        }

        for (int i = 0; i < arrayAsString.length; i+=2) {

            int a = Integer.parseInt(arrayAsString[i]);
            int b = Integer.parseInt(arrayAsString[i + 1]);
            if ((a + b) % 2 != 0){
                System.out.printf("%d, %d -> different\n", a, b);
            }
            else if(a % 2 != 0){
                System.out.printf("%d, %d -> both are odd\n", a, b);
            }
            else {
                System.out.printf("%d, %d -> both are even\n", a, b);
            }
        }
    }
}
