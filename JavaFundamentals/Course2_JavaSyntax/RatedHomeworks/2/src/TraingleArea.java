import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class TraingleArea {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int aX = input.nextInt();
        int aY = input.nextInt();
        int bX = input.nextInt();
        int bY = input.nextInt();
        int cX = input.nextInt();
        int cY = input.nextInt();

        double triangleArea = (aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2;

        System.out.printf("The area of triangle is: %.0f", Math.abs(triangleArea));
    }
}
