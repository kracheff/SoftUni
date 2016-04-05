package com.company;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class _9_MostFrequentWord {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] elemnts = scan.nextLine().toLowerCase().split("[ .,:?#@!-+=]+");
        List<String> appears = new ArrayList<String>();
        List<String> ignoreWord = new ArrayList<String>();
        scan.close();
        int maxAppears = 1;
        int currentAppears = 1;
        for (int i = 0; i < elemnts.length; i++) {
            String word = elemnts[i];
            for (int j = 0; j < elemnts.length; j++) {
                if (i == j) {
                    continue;
                }
                if (ignoreWord.contains(word)) {
                    continue;
                }
                String nextWord = elemnts[j];
                if (word.equals(nextWord)) {
                    currentAppears++;
                }
            }
            ignoreWord.add(word);
            if (currentAppears > maxAppears  ) {
                appears.clear();
                appears.add(word);
                maxAppears = currentAppears;
                currentAppears = 1;
            } else if(currentAppears == maxAppears && currentAppears > 1){
                appears.add(word);
                currentAppears = 1;
            }
        }
        Collections.sort(appears);
        for (String element : appears) {
            System.out.printf(element + " -> %d times",maxAppears);
            System.out.println();
        }
    }
}
