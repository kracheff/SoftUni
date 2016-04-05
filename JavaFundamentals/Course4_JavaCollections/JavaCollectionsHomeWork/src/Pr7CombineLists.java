import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by user on 30.03.2016.
 */
public class Pr7CombineLists {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] list1 = sc.nextLine().split(" ");
        String[] list2 = sc.nextLine().split(" ");

        ArrayList<Character> list1Chars = new ArrayList<>();
        ArrayList<Character> list2Chars = new ArrayList<>();
        ArrayList<Character> finalList = new ArrayList<>();


        for (int i = 0; i < list1.length; i++) {
            list1Chars.add(list1[i].charAt(0));
        }
        for (int i = 0; i < list2.length; i++) {
            list2Chars.add(list2[i].charAt(0));
        }
        for (int i = 0; i < list1.length; i++) {
            finalList.add(list1[i].charAt(0));
        }

        for (int i = 0; i < list2Chars.size(); i++) {
            if (!list1Chars.contains(list2Chars.get(i))) {
                finalList.add(list2Chars.get(i));
            }
        }

        for (int i = 0; i < finalList.size(); i++) {
            System.out.print(finalList.get(i) + " ");
        }
    }
}
