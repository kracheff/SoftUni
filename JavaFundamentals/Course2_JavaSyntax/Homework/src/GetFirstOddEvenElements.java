import java.util.ArrayList;
import java.util.Scanner;

public class GetFirstOddEvenElements {
    public static void main(String[] args) {
       // Input
        Scanner sc = new Scanner(System.in);
        ArrayList<Integer> collection = new ArrayList<Integer>();

        while (sc.hasNextInt()){
            collection.add(sc.nextInt());
        }
        sc.next();
        int numberOfElements = sc.nextInt();
        String oddOrEven = sc.next();

        ArrayList<Integer> oddsList = new ArrayList<Integer>();
        ArrayList<Integer> evensList = new ArrayList<Integer>();
        int oddCounter = 0;
        int evenCounter = 0;

        if(oddOrEven.equals("even")) {

            for (int i = 0; i < collection.size(); i++) {
                if (collection.get(i) % 2 == 0) {
                    evensList.add(collection.get(i));
                    evenCounter++;
                    if (evenCounter > numberOfElements) {
                        break;
                    }
                }
            }
            System.out.println(evensList);
        }
        else {
            for (int i = 0; i < collection.size(); i++) {
                if (collection.get(i) % 2 == 1) {
                    oddsList.add(collection.get(i));
                    oddCounter++;
                    if (oddCounter > numberOfElements) {
                        break;
                    }
                }
            }
            System.out.println(oddsList);
        }
    }
}
