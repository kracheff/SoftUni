package com.company;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Pr11GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scan=new Scanner(System.in);

        String input=scan.nextLine();
        String secondLine=scan.nextLine();
        String[]second=secondLine.split(" ");
        String comand= second[2];
        int n=Integer.parseInt(second[1]);
        String[]array=input.split(" ");
        List<Integer>numbers= new ArrayList<Integer>();
        for (int i = 0; i < array.length; i++) {
            String a=array[i];
            numbers.add(Integer.parseInt(a));
        }
        int counter=0;
        String o="odd";
        if(comand.equals(o)) {
            for (int i = 0; i < numbers.size(); i++) {
                if(counter==n){
                    break;
                }
                if (numbers.get(i) % 2 != 0){
                    System.out.println(numbers.get(i));
                    counter++;
                }

            }
        } else{

            System.out.println();
        }
    }
}
