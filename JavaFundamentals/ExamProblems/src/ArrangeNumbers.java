import java.util.*;

/**
 * Created by user on 19.04.2016.
 */
public class ArrangeNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] input = sc.nextLine().split(", ");
        TreeMap<String, String> numbersAndText = new TreeMap<>();
        String[] sortedInput = new String[input.length];

        for (int i = 0; i < input.length; i++) {
            String toEnglish = "";
            toEnglish += textOfChar(input[i].charAt(0));
            if (input[i].length() > 1) {
                for (int j = 1; j < input[i].length(); j++) {
                    toEnglish += "-" + textOfChar(input[i].charAt(j));
                }
            }
            sortedInput[i] = toEnglish;
            numbersAndText.put(toEnglish, input[i]);
        }

//        Arrays.sort(sortedInput);

        String output = "";

//        for (String s : sortedInput) {
//            for (Map.Entry<String, String> entry : numbersAndText.entrySet()) {
//                if (entry.getKey().equals(s)) {
//                    output += entry.getValue() + ", ";
//                }
//            }
//        }
//        System.out.println(output.substring(0, output.length()-2));
        for (String s : numbersAndText.values()) {
            System.out.println(s);
        }
    }

    public static String textOfChar(char inputChar) {
        String outputString = "";

        switch (inputChar) {
            case '0':
                outputString = "zero";
                break;
            case '1':
                outputString = "one";
                break;
            case '2':
                outputString = "two";
                break;
            case '3':
                outputString = "three";
                break;
            case '4':
                outputString = "four";
                break;
            case '5':
                outputString = "five";
                break;
            case '6':
                outputString = "six";
                break;
            case '7':
                outputString = "seven";
                break;
            case '8':
                outputString = "eight";
                break;
            case '9':
                outputString = "nine";
                break;
            default:
                break;
        }
        return outputString;
    }
}
