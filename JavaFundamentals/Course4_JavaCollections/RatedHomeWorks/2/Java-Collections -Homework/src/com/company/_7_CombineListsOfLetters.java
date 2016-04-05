package com.company;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.lang.String;

public class _7_CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        char [] basicText = sc.nextLine().replace(" ", "").toCharArray();
        char [] addText = sc.nextLine().replace(" ", "").toCharArray();

        ArrayList<Character> basicList = new ArrayList<>();
        ArrayList<Character> addList = new ArrayList<>();

        for (Character letter:basicText){
            basicList.add(letter);
            addList.add(letter);
        }
        for (Character letter :addText){
            if (!addList.contains(letter)){
                basicList.add(letter);
            }
        }
        for (Character letter:basicList){
            System.out.print(letter + " ");
        }
    }
}
