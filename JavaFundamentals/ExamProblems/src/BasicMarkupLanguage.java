import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 22.04.2016.
 */
public class BasicMarkupLanguage {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);


        int lineNumbers = 1;
        String command = "";
        String output = "";
        int repeatCount = 0;

        // Regex
        String allCommandsRegex = "\\binverse content\\b|\\breverse content\\b|\\brepeat value\\b|\\bcontent\\b";
        String outputRegex = "[^\"/<>]+";
        String repeatValueRegex = "[0-9]+";

        String input = sc.nextLine();
        Pattern p = Pattern.compile("\\bstop\\b");
        Matcher m = p.matcher(input);

        // Main Loop
        while (!m.find()) {

            String[] elementsOfInput = input.split("=");

            Pattern patternCommand = Pattern.compile(allCommandsRegex);
            Matcher matcherCommand = patternCommand.matcher(elementsOfInput[0]);

            while (matcherCommand.find()) {
                command = matcherCommand.group();
            }
            String inputParameter = "";
            if(elementsOfInput.length == 2){

                Pattern patternInputParameter = Pattern.compile(outputRegex);
                Matcher matcherInputParameter = patternInputParameter.matcher(elementsOfInput[1]);

                while (matcherInputParameter.find()) {
                    inputParameter = matcherInputParameter.group();
                }

                if(command.equals("inverse content")){
                    if(inputParameter != null){
                    output = inverseContent(inputParameter);
                    System.out.println(lineNumbers + ". " + output);
                    lineNumbers++;
                    }
                } else if(command.equals("reverse content")){
                    if(inputParameter != null) {
                    output = reverseContent(inputParameter);
                    System.out.println(lineNumbers + ". " + output);
                    lineNumbers++;
                    }
                }
            } else if(elementsOfInput.length == 3){

                Pattern repeatValue = Pattern.compile(repeatValueRegex);
                Matcher matcherRepeatValue = repeatValue.matcher(elementsOfInput[1]);

                while (matcherRepeatValue.find()) {
                    repeatCount = Integer.parseInt(matcherRepeatValue.group());
                }

                Pattern patternInputParameter = Pattern.compile(outputRegex);
                Matcher matcherInputParameter = patternInputParameter.matcher(elementsOfInput[2]);

                while (matcherInputParameter.find()) {
                    inputParameter = matcherInputParameter.group();
                }

                for (int i = 0; i < repeatCount; i++) {
                    if(inputParameter != null){
                    System.out.println(lineNumbers + ". " + inputParameter);
                    lineNumbers++;
                    }
                }
            }

            input = sc.nextLine();
            p = Pattern.compile("\\bstop\\b");
            m = p.matcher(input);
        }
        sc.close();
    }

    private static String reverseContent(String inputParameter) {
        String output = "";

        for (int i = inputParameter.length() - 1; i >= 0; i--) {
             output += "" + inputParameter.charAt(i);
        }
        return output;
    }

    private static String inverseContent(String inputParameter) {
        String output = "";

        for (int i = 0; i < inputParameter.length(); i++) {
            if(inputParameter.charAt(i) >= 'A' && inputParameter.charAt(i) <= 'Z'){
                output += (char)(inputParameter.charAt(i) + 32);
            } else if (inputParameter.charAt(i) >= 'a' && inputParameter.charAt(i) <= 'z'){
                output += (char)(inputParameter.charAt(i) - 32);
            }
        }
        return output;
    }
}
