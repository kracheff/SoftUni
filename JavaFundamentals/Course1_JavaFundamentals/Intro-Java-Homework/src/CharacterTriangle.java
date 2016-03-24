import java.util.Scanner;

/**
 * Created by user on 18.03.2016.
 */
public class CharacterTriangle {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        int k = 1;

        for (int i = 0; i < number * 2 - 1; i++) {
            if (i < number){
                for (char j = 'a'; j <= 'a' + i ; j++) {
                    System.out.print(j + " ");
                }
            }
            else {
                for (char j = 'a'; j < 'a' + i - k; j++) {
                    System.out.print(j + " ");
                }
                k+=2;
            }
        System.out.println();
        }
    }
}
