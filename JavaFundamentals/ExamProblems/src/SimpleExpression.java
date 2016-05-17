import java.math.BigDecimal;
import java.util.DoubleSummaryStatistics;
import java.util.LinkedList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 17.04.2016.
 */
public class SimpleExpression {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String regexNumbersOnly = "[^+\\- ]+";
        String regexAritmeticOperations = "[+\\-]";
        String combinedRegex = "([^+\\- ]+)|([+\\-])";

        String input = sc.nextLine();

        Pattern p = Pattern.compile(combinedRegex);
        Matcher m = p.matcher(input);
        LinkedList<String> expression = new LinkedList<>();

        while (m.find()) {
            expression.add(m.group());
        }

        BigDecimal sum;
        if(expression.get(0) != "+" && expression.get(0) != "-"){
            sum = new BigDecimal(expression.get(0));
        }else {
            sum = new BigDecimal("0");
        }

        for (int i = 0; i < expression.size() - 1; i++) {
                if (expression.get(i).equals("+")) {
                    sum = sum.add(new BigDecimal(expression.get(i+1)));
                } else if(expression.get(i).equals("-")){
                    sum = sum.subtract(new BigDecimal(expression.get(i+1)));
                }
        }
        System.out.printf("%1$.10f", sum);
    }
}
