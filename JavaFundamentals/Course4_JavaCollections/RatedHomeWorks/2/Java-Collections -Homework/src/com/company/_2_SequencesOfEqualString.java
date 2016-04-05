package com.company;

import java.util.Scanner;

public class _2_SequencesOfEqualString {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] line = input.nextLine().split(" ");

        String prev = null;
        String curr = null;
        for (int i = 0; i < line.length; i++) {
            if (i == 0) {
                System.out.print(line[i] + " ");
                continue;
            }
            prev = line[i - 1];
            curr = line[i];
            if (curr.equals(prev)) {
                System.out.print(curr + " ");
            } else {
                System.out.println();
                System.out.print(curr + " ");
            }
        }
    }
}
