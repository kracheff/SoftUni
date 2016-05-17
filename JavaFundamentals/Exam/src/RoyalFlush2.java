import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RoyalFlush2 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int numberOfLines = Integer.parseInt(sc.nextLine());
        List<String> allCards = new ArrayList<>();
        int totalRF = 0;

        Pattern p = Pattern.compile("[2-9][cdhs]|[AKQJ][cdhs]|[1][0][cdhs]");

        for (int i = 0; i < numberOfLines; i++) {
            String input = sc.nextLine();
            Matcher m = p.matcher(input);

            while (m.find()) {
                allCards.add(m.group());
            }
        }

        System.out.println(allCards);

        ArrayList<String> clubsRF = new ArrayList<>();
        ArrayList<String> diamondsRF = new ArrayList<>();
        ArrayList<String> heartsRF = new ArrayList<>();
        ArrayList<String> spadesRF = new ArrayList<>();

        for (int i = 0; i < allCards.size(); i++) {
            String suit = "" + allCards.get(i).charAt(allCards.get(i).length() - 1);
            String face = "" + allCards.get(i).substring(0, allCards.get(i).length() - 1);
        }
    }
}
