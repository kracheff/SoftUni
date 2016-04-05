import java.util.*;
public class SortArrayOfNumbers {
    public static void main (String args[]){
        Scanner java = new Scanner(System.in);
        int number = java.nextInt();
        int[] array = new int [number];
        for ( int i = 0;i<number;i++){
            array[i]= java.nextInt();
        }
        Arrays.sort(array);
        for (int i = 0 ;i< array.length;i++) {
            System.out.print(array[i]+" ");
        }
    }
}
