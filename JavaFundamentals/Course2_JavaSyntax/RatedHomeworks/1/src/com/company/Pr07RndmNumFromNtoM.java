package com.company;

import java.util.*;


public class Pr07RndmNumFromNtoM {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        Integer n = scan.nextInt();
        Integer m = scan.nextInt();
        Random ran=new Random();
        Integer max=Math.max(n,m);
        Integer min=Math.min(n,m);
        List<Integer> rndmNum=new ArrayList<>();
        randomizedNumbers(min,max,rndmNum);
        for (int i = 0; i < rndmNum.size(); i++) {
            System.out.print(rndmNum.get(i)+" ");

        }
    }

    private static void randomizedNumbers(Integer min, Integer max, List<Integer> rndmNum) {
        Random randomGenerator = new Random();
        for (int i = 0; i <=max-min ; i++) {
            Integer randomNumber = randomGenerator.nextInt(max-min+1)+min;
            while (rndmNum.contains(randomNumber)){
                randomNumber=randomGenerator.nextInt(max-min+1)+min;
            }
            rndmNum.add(randomNumber);
        }
    }
}
