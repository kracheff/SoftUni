import java.util.Locale;
import java.util.Scanner;

/**
 * Created by user on 22.03.2016.
 */
public class Tests {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);
        Integer numberOfLines= reader.nextInt();
        triangleOfAlphabets(numberOfLines);
    }

    private static void triangleOfAlphabets(Integer numberOfLines) {
        upperRows(numberOfLines);
        lowerRows(numberOfLines);
    }

    private static void lowerRows(Integer numberOfLines) {
        for (int i = numberOfLines - 1; i > 0 ; i--) {
            printLineOfAlphabets(i);
        }
    }

    private static void upperRows(int numberOfLines) {
        for (int i = 1; i <= numberOfLines; i++) {
            printLineOfAlphabets(i);
        }
    }

    private static void printLineOfAlphabets(int i) {
        for (char c = 'a'; c < 'a' + i ; c++) {
            System.out.print(c + " ");
        }
        System.out.println();
    }
}
