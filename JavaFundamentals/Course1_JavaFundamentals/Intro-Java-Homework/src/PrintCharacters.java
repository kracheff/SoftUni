/**
 * Created by user on 18.03.2016.
 */
public class PrintCharacters {
    public static void main(String[] args) {
        for (char c = 'a'; c <= 'z'; c++) {
            if (c != 'z') {
                System.out.print(c + " ");
            }
            else {
                System.out.print(c);
            }
        }
    }
}
