package com.company;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class _8_ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toLowerCase().split("[ .?:]+");
        scan.close();
        List<String> inputLines = new ArrayList<String>();
        for (int i = 0; i < input.length; i++) {
            String current = input[i];
            if (!inputLines.contains(current)) {
                inputLines.add(current);
            }
        }
        Collections.sort(inputLines);

        for (String word : inputLines) {
            System.out.print(word + " ");
        }

    }
}
