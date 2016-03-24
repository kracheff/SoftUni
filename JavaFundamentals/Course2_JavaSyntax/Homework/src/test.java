import java.util.ArrayList;
import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
/**
 * Created by user on 23.03.2016.
 */
public class test {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int firstNum = console.nextInt();
        int secondNum = console.nextInt();

        if (firstNum > secondNum){
            rndmInt(firstNum, secondNum);
        }
        else if (secondNum > firstNum){
            rndmInt(secondNum, firstNum);
        }
        else{
            System.out.print(firstNum);
        }
    }

    public static void rndmInt(int max, int min){

        ArrayList<Integer> list = new ArrayList<>();
        for (int i = min + 1; i < max; i++) {
            list.add(i);
        }

        Random rand = new Random();
        while(list.size() > 0){
            int index = rand.nextInt(list.size());
            System.out.printf("%d" + " ", list.remove(index));
        }
    }
}
