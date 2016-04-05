package com.company;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _10_CardsFrequencies {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] elements = scan.nextLine().split("[ ♠♥♦♣]+");
        scan.close();
        int elementsCount = elements.length;
        int appearsCount = 1;
        String elem1;
        List<String> checkingCard = new ArrayList<String>();
        for (int i = 0; i < elements.length; i++) {
            elem1 = elements[i];
            if (checkingCard.contains(elem1)) {
                continue;
            }
            for (int j = i + 1; j < elements.length; j++) {
                String elem2 = elements[j];
                if (elem1.contains(elem2)) {
                    appearsCount++;
                }
            }
            double result =  ((double)appearsCount * 100) /  elementsCount;
            System.out.printf(elem1 + " -> %.2f",result);
            System.out.println("%");
            appearsCount = 1;
            checkingCard.add(elem1);
        }
    }
}
