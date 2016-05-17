import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by user on 08.05.2016.
 */
public class Royalism {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] allPeople = sc.nextLine().split(" ");
        int royalistsCount = 0;
        int nonRoyalistsCount = 0;
        List<String> royalists = new ArrayList<>();
        List<String> nonRoyalists = new ArrayList<>();

        for (String person : allPeople) {
            int counter = 0;

            for (int i = 0; i < person.length(); i++) {
                counter += (int) person.charAt(i);

                if (counter > 26){
                    while (counter >= 26){
                        counter -= 26;
                    }
                }
            }
            if (counter == 18){
                royalistsCount++;
                royalists.add(person);
            }
            else {
                nonRoyalistsCount++;
                nonRoyalists.add(person);
            }
        }

        if (royalistsCount > 0){
            if (royalistsCount >= nonRoyalistsCount){
                System.out.println("Royalists - " + royalistsCount);
                for (String royalist : royalists) {
                    System.out.println(royalist);
                }
                System.out.println("All hail Royal!");
            }
            else {
                for (String nonRoyalist : nonRoyalists) {
                    System.out.println(nonRoyalist);
                }
                System.out.println("Royalism, Declined!");
            }
        }
    }
}
