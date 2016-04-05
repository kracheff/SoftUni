package com.company;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int m = sc.nextInt();
        int bigger = m;
        int smaller = n;

        if (n > m) {
            bigger = n;
            smaller = m;
        }

        List<Integer> numbers = new ArrayList<>();
        int temp = smaller;
        for (int i = 0; i <= (bigger - smaller); i++) {
            numbers.add(temp);
            temp++;
        }

        Collections.shuffle(numbers);
        System.out.println(numbers);


    }
}
