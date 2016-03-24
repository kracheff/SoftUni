import java.util.Scanner;
import java.util.StringJoiner;

public class DecimalToBase7 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int input = sc.nextInt();
        String output = "";

        while (input > 0){
            output += input % 7;
            input /= 7;
        }

        //reverse the result
        String finalOutput = "";
        for (int i = output.length(); i > 0; i--) {
            finalOutput += output.charAt(i - 1);
        }
        // print the final result
        System.out.println(finalOutput);
    }
}
