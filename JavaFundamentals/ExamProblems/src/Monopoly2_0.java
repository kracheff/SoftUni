import java.util.Scanner;

/**
 * Created by user on 22.04.2016.
 */
public class Monopoly2_0 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] inputNumbers = sc.nextLine().split(" ");
        int numberOfRows = Integer.parseInt(inputNumbers[0]);
        int numberOfCols = Integer.parseInt(inputNumbers[1]);
        String[] rows = new String[numberOfRows];

        for (int i = 0; i < numberOfRows; i++) {
            rows[i] = sc.nextLine();
        }

        int turns = 0;
        int hotels = 0;
        int money = 50;

        for (int i = 0; i < numberOfRows; i++) {
            if (i%2 == 0){
                for (int j = 0; j < numberOfCols; j++) {
                    if(rows[i].charAt(j) == 'H'){
                        hotels++;
                        System.out.println("Bought a hotel for " + money + ". Total hotels: " + hotels + ".");
                        money -= money;
                        money += hotels * 10;
                        turns++;
                    } else if(rows[i].charAt(j) == 'J'){
                        money += hotels * 10 * 3;
                        System.out.println("Gone to jail at turn " + turns + ".");
                        turns += 3;
                    } else if (rows[i].charAt(j) == 'F'){
                        money += hotels * 10;
                        turns++;
                    } else if (rows[i].charAt(j) == 'S'){
                        if ((i + 1) * (j + 1) >= money){
                            System.out.println("Spent " + money + " money at the shop.");
                            money -= money;
                        } else {
                            System.out.println("Spent " + ((i + 1) * (j + 1)) + " money at the shop.");
                            money -= (i + 1) * (j + 1);
                        }
                    }
                    turns++;
                    money += hotels * 10;
                }
            }else {
                for (int j = rows[i].length() - 1; j >= 0; j--) {
                    if(rows[i].charAt(j) == 'H'){
                        hotels++;
                        System.out.println("Bought a hotel for " + money + ". Total hotels: " + hotels + ".");
                        money -= money;
                        money += hotels * 10;
                        turns++;
                    } else if(rows[i].charAt(j) == 'J'){
                        money += hotels * 10 * 3;
                        System.out.println("Gone to jail at turn " + turns + ".");
                        turns += 3;
                    } else if (rows[i].charAt(j) == 'F'){
                        money += hotels * 10;
                        turns++;
                    } else if (rows[i].charAt(j) == 'S'){
                        if ((i + 1) * (j + 1) >= money){
                            System.out.println("Spent " + money + " money at the shop.");
                            money -= money;
                        } else {
                            System.out.println("Spent " + ((i + 1) * (j + 1)) + " money at the shop.");
                            money -= (i + 1) * (j + 1);
                        }
                    }
                    turns++;
                    money += hotels * 10;
                }
            }
        }
        System.out.println("Turns " + turns);
        System.out.println("Money " + money);
    }
}
