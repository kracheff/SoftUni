import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int aX = sc.nextInt();
        int aY = sc.nextInt();

        int bX= sc.nextInt();
        int bY = sc.nextInt();

        int cX = sc.nextInt();
        int cY = sc.nextInt();

        double area =
                Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY - bY)) / 2);

        System.out.printf("%1$.0f", area);
    }
}