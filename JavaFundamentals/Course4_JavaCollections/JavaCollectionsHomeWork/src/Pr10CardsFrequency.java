import java.util.*;

/**
 * Created by user on 31.03.2016.
 */
public class Pr10CardsFrequency {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        List<String> newList = Arrays.asList(input);
        Set<String> uniques = new HashSet<>(newList);
        HashMap<String, Integer> playingCards = new HashMap<>();



        for (String card : input) {
            card = card.substring(0, card.length() - 1);
            Integer appearances = playingCards.get(card);
            if(appearances == null){
                appearances = 0;
            }
            playingCards.put(card, appearances + 1);
        }
        ArrayList<String> inOrderOfAppearence = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            if(!inOrderOfAppearence.contains(input[i].substring(0, input[i].length() - 1)));
            inOrderOfAppearence.add(input[i].substring(0, input[i].length() - 1));
        }
        int index = 0;

        for (int i = 0; i < inOrderOfAppearence.size(); i++) {
            for (Map.Entry<String, Integer> entry : playingCards.entrySet()) {
                if(inOrderOfAppearence.get(i).equals(entry.getKey())){
                    System.out.println(inOrderOfAppearence.get(i) + " -> " + entry.getValue());
                }
            }
        }

        System.out.println(inOrderOfAppearence);
    }
}
