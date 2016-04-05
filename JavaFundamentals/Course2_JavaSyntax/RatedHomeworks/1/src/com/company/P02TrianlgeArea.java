package com.company;


import java.util.Scanner;

public class P02TrianlgeArea {
    public static void main(String[] args) {
        /**area	=	|Ax(By − Cy) + Bx(Cy	− Ay) + Cx(Ay − By)|  /2
         **/
        Scanner scan = new Scanner(System.in);
        int aX=scan.nextInt(), aY=scan.nextInt();
        scan.nextLine();
        int bX=scan.nextInt(), bY=scan.nextInt();
        scan.nextLine();
        int cX=scan.nextInt(), cY=scan.nextInt();

        System.out.println(Math.abs(aX*(bY-cY)+bX*(cY-aY)+cX*(aY-bY))/2);
    }
}
