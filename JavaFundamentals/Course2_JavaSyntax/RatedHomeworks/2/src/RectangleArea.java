import java.util.Scanner;

/**
 * Created by apch on 3/23/16.
 */
public class RectangleArea {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int a = input.nextInt();
        int b = input.nextInt();

        int rectArea = a * b;

        System.out.print(rectArea);
    }
}
