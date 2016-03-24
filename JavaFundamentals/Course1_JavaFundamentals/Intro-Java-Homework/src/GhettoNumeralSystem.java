import java.util.Scanner;

/**
 * Created by user on 19.03.2016.
 */
public class GhettoNumeralSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.next();
        String ghettoEquivalent = "";

        for (int i = 0; i < input.length(); i++) {
            switch (input.charAt(i)){

                case '0': ghettoEquivalent += "Gee"; break;
                case '1': ghettoEquivalent += "Bro"; break;
                case '2': ghettoEquivalent += "Zuz"; break;
                case '3': ghettoEquivalent += "Ma"; break;
                case '4': ghettoEquivalent += "Duh"; break;
                case '5': ghettoEquivalent += "Yo"; break;
                case '6': ghettoEquivalent += "Dis"; break;
                case '7': ghettoEquivalent += "Hood"; break;
                case '8': ghettoEquivalent += "Jam"; break;
                case '9': ghettoEquivalent += "Mack"; break;
            }
        }
        System.out.println(ghettoEquivalent);
    }
}
