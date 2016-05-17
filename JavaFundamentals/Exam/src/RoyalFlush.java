import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 08.05.2016.
 */
public class RoyalFlush {
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

        ArrayList<String> clubsRF = new ArrayList<>();
        ArrayList<String> diamondsRF = new ArrayList<>();
        ArrayList<String> heartsRF = new ArrayList<>();
        ArrayList<String> spadesRF = new ArrayList<>();

        for (int i = 0; i < allCards.size(); i++) {
            String suit = "" + allCards.get(i).charAt(allCards.get(i).length() - 1);
            String face = "" + allCards.get(i).substring(0, allCards.get(i).length() - 1);

//        if (currentRF.contains(face)) {
//            currentRF.clear();
//        } else {
//            currentRF.add(face);
//        }
//        return currentRF;



        if (face.equals("10")) {
                switch (suit) {
                    case "c":
                        manipulateHand(clubsRF, face);
                        if (clubsRF.size() == 4) {
                            System.out.println("Royal Flush Found – Clubs");
                            totalRF++;
                            clubsRF.clear();
                        }
                        break;
                    case "d":
                        manipulateHand(diamondsRF, face);
                        if (diamondsRF.size() == 4) {
                            System.out.println("Royal Flush Found – Diamonds");
                            totalRF++;
                            diamondsRF.clear();
                        }
                        break;
                    case "h":
                        manipulateHand(heartsRF, face);
                        if (heartsRF.size() == 4) {
                            System.out.println("Royal Flush Found – Hearts");
                            totalRF++;
                            heartsRF.clear();
                        }

                        break;
                    case "s":
                        manipulateHand(spadesRF, face);
                        if (spadesRF.size() == 4) {
                            System.out.println("Royal Flush Found - Spades");
                            totalRF++;
                            spadesRF.clear();
                        }
                        break;
                }
            }
            else if (face.equals("J")) {

                switch (suit) {
                    case "c":
                        if (clubsRF.contains("10")){
                            manipulateHand(clubsRF, face);
                            if (clubsRF.size() == 4) {
                                System.out.println("Royal Flush Found - Clubs");
                                totalRF++;
                                clubsRF.clear();
                            }
                        }
                        break;
                    case "d":
                        if (diamondsRF.contains("10")){
                        manipulateHand(diamondsRF, face);
                        if (diamondsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Diamonds");
                            totalRF++;
                            diamondsRF.clear();
                        }}
                        break;
                    case "h":
                        if (heartsRF.contains("10")){
                        manipulateHand(heartsRF, face);
                        if (heartsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Hearts");
                            totalRF++;
                            heartsRF.clear();
                        }}

                        break;
                    case "s":
                        if(spadesRF.contains("10")){
                        manipulateHand(spadesRF, face);
                        if (spadesRF.size() == 4) {
                            System.out.println("Royal Flush Found - Spades");
                            totalRF++;
                            spadesRF.clear();
                        }}
                        break;
                }
            }
            else if (face.equals("Q")) {

                switch (suit) {
                    case "c":
                        if(clubsRF.contains("10") && clubsRF.contains("J")){

                            manipulateHand(clubsRF, face);
                        if (clubsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Clubs");
                            totalRF++;
                            clubsRF.clear();
                        }}
                        break;
                    case "d":
                        if(diamondsRF.contains("10") && diamondsRF.contains("J")){

                            manipulateHand(diamondsRF, face);
                        if (diamondsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Diamonds");
                            totalRF++;
                            diamondsRF.clear();
                        }}
                        break;
                    case "h":
                        if(heartsRF.contains("10") && heartsRF.contains("J")){

                            manipulateHand(heartsRF, face);
                        if (heartsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Hearts");
                            totalRF++;
                            heartsRF.clear();
                        }}

                        break;
                    case "s":
                        if(spadesRF.contains("10") && spadesRF.contains("J")){

                            manipulateHand(spadesRF, face);
                        if (spadesRF.size() == 4) {
                            System.out.println("Royal Flush Found - Spades");
                            totalRF++;
                            spadesRF.clear();
                        }}
                        break;
                }
            }
            else if (face.equals("K")) {

                switch (suit) {
                    case "c":
                        if(clubsRF.contains("10") && clubsRF.contains("J") && clubsRF.contains("Q")){

                            manipulateHand(clubsRF, face);
                        if (clubsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Clubs");
                            totalRF++;
                            clubsRF.clear();
                        }}
                        break;
                    case "d":
                        if(diamondsRF.contains("10") && diamondsRF.contains("J") && diamondsRF.contains("Q")){

                            manipulateHand(diamondsRF, face);
                        if (diamondsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Diamonds");
                            totalRF++;
                            diamondsRF.clear();
                        }}
                        break;
                    case "h":
                        if(heartsRF.contains("10") && heartsRF.contains("J") && heartsRF.contains("Q")){

                            manipulateHand(heartsRF, face);
                        if (heartsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Hearts");
                            totalRF++;
                            heartsRF.clear();
                        }}

                        break;
                    case "s":
                        if(spadesRF.contains("10") && spadesRF.contains("J") && spadesRF.contains("Q")){

                            manipulateHand(spadesRF, face);
                        if (spadesRF.size() == 4) {
                            System.out.println("Royal Flush Found - Spades");
                            totalRF++;
                            spadesRF.clear();
                        }}
                        break;
                }
            }
            else if (face.equals("A")) {

                switch (suit) {
                    case "c":
                        if(clubsRF.contains("10") && clubsRF.contains("J") && clubsRF.contains("Q") && clubsRF.contains("K")){

                            manipulateHand(clubsRF, face);
                        if (clubsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Clubs");
                            totalRF++;
                            clubsRF.clear();
                        }}
                        break;
                    case "d":
                        if(diamondsRF.contains("10") && diamondsRF.contains("J") && diamondsRF.contains("Q") && diamondsRF.contains("K")){

                            manipulateHand(diamondsRF, face);
                        if (diamondsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Diamonds");
                            totalRF++;
                            diamondsRF.clear();
                        }}
                        break;
                    case "h":
                        if(heartsRF.contains("10") && heartsRF.contains("J") && heartsRF.contains("Q") && heartsRF.contains("K")){

                            manipulateHand(heartsRF, face);
                        if (heartsRF.size() == 4) {
                            System.out.println("Royal Flush Found - Hearts");
                            totalRF++;
                            heartsRF.clear();
                        }}

                        break;
                    case "s":
                        if(spadesRF.contains("10") && spadesRF.contains("J") && spadesRF.contains("Q") && spadesRF.contains("K")){

                            manipulateHand(spadesRF, face);
                        if (spadesRF.size() == 4) {
                            System.out.println("Royal Flush Found - Spades");
                            totalRF++;
                            spadesRF.clear();
                        }}
                        break;
                }
            }
        }
        System.out.println("Royal's Royal Flushes - " + totalRF + ".");
    }

    private static ArrayList<String> manipulateHand(ArrayList<String> currentRF, String face) {
        if (currentRF.contains(face)) {
            currentRF.clear();
        } else {
            currentRF.add(face);
        }
        return currentRF;
    }
}
