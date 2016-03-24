package com.company;
import java.util.Scanner;

public class SumNumbersFrom1ToN {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int sum =0;
        int N = Integer.parseInt(input.nextLine());
        for (int i = 0; i <=N ; i++) {

            sum+=i;
        }
        System.out.println(sum);
    }
}

