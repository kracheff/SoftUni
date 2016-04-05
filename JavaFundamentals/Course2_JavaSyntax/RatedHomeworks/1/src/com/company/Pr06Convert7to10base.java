package com.company;

import java.util.Scanner;


public class Pr06Convert7to10base {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int in7base =scan.nextInt();
        int in10base=0;
        int counter=0;
        for (int i = in7base; i >0; i/=10) {

            in10base+=(i%10)*Math.pow(7,counter);
            counter++;
        }
        System.out.println(in10base);
    }
}
