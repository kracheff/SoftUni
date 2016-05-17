import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by user on 26.04.2016.
 */
public class MerlahShake {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String pattern = sc.nextLine();
        sc.close();

        int allMatchesCounter = 1;

        while (true) {
            if(pattern.length() < 1 || pattern.length() > input.length()){
                System.out.println("No shake.");
                break;
            }

            // Find all available matches

            for (int i = 0; i < input.length() - pattern.length() + 1; i++) {
                String tempString = "";
                for (int j = 0; j < pattern.length(); j++) {
                    tempString += input.charAt(i + j);
                }
                if (tempString.equals(pattern)) {
                    allMatchesCounter++;
                }
            }

            // Stop the program if there are no matches

            if (allMatchesCounter == 0) {
                System.out.println("No shake.");
                System.out.println(input);
                break;
            }

            ArrayList<String> inputArrList = new ArrayList<>();
            ArrayList<String> patternArrList = new ArrayList<>();
            inputArrList = convertToArrayList(input);
            patternArrList = convertToArrayList(pattern);

            // If there is only one match:

            if (allMatchesCounter == 1) {
                for (int i = 0; i < input.length() - pattern.length() + 1; i++) {
                    String tempString = "";
                    for (int j = 0; j < pattern.length(); j++) {
                        tempString += input.charAt(i + j);
                    }
                    if (tempString.equals(pattern)) {
                        for (int j = 0; j < pattern.length(); j++) {
                            inputArrList.remove(i);
                        }
                        // Reduce the pattern
                        patternArrList.remove(pattern.length() / 2);
                        pattern = "";
                        for (String s : patternArrList) {
                            pattern += s;
                        }
                        // Reduce the input string
                        input = "";
                        for (String s : inputArrList) {
                            input += s;
                        }
                    }
                }

                System.out.println("No shake.");
                System.out.println(input);
                break;
            }

            // Do the stuff for couter >= 2
            if (allMatchesCounter >= 2) {

                int currentCounter = 0;

                for (int i = 0; i < input.length() - pattern.length() + 1; i++) {
                    String tempString = "";
                    for (int j = 0; j < pattern.length(); j++) {
                        tempString += input.charAt(i + j);
                    }
                    if (tempString.equals(pattern)) {
                        currentCounter++;
                        if (currentCounter == 1 || currentCounter == allMatchesCounter) {
                            for (int j = 0; j < pattern.length(); j++) {
                                if(currentCounter == 1){
                                inputArrList.remove(i);
                                } else {
                                    inputArrList.remove(i - pattern.length());
                                }
                            }
                        }
                    }
                }
                System.out.println("Shaked it.");

                // Reduce the pattern
                patternArrList.remove(pattern.length() / 2);
                pattern = "";
                for (String s : patternArrList) {
                    pattern += s;
                }
                // Reduce the input string
                input = "";
                for (String s : inputArrList) {
                    input += s;
                }
            }
        }
    }

    private static ArrayList<String> convertToArrayList(String input) {
        ArrayList<String> output = new ArrayList<>();
        for (int i = 0; i < input.length(); i++) {
            output.add(Character.toString(input.charAt(i)));
        }
        return output;
    }
}
