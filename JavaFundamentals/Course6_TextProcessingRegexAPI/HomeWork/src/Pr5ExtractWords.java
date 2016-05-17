import java.util.Scanner;

/**
 * Created by user on 07.04.2016.
 */
public class Pr5ExtractWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split("[^a-zA-Z]+");
        String output = "";

        for (String s : input) {
            output += s + " ";
        }
        System.out.println(output.trim());
    }

}
