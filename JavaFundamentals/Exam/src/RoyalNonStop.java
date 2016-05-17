import java.math.BigDecimal;
import java.math.RoundingMode;
import java.text.DecimalFormat;
import java.util.Locale;
import java.util.Scanner;

/**
 * Created by user on 08.05.2016.
 */
public class RoyalNonStop {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] dimentions = sc.nextLine().split(" ");
        short rows = Short.parseShort(dimentions[0]);
        short cols = Short.parseShort(dimentions[1]);

        String[] prices = sc.nextLine().split(" ");
        double lukankaPrice = Double.parseDouble(prices[0]);
        double rakijaPrice = Double.parseDouble(prices[1]);

        String destination = sc.nextLine();

        if (destination.equals("Royal Close")) {
            System.out.println("0.000000");
            System.out.println("0");
            return;
        }

        short customerCount = 0;

        boolean[][] matrix = new boolean[rows][cols];
        BigDecimal rechnung = BigDecimal.ZERO;

        while (!destination.equals("Royal Close")) {
            customerCount++;
            short destinationRow = Short.parseShort(destination.split(" ")[0]);
            short destinationCol = Short.parseShort(destination.split(" ")[1]);
            double currentPrice = 0;
            boolean isLukanka = false;
            short currentRow = destinationRow;
            short currentCol = destinationCol;
            BigDecimal currentRechnung = new BigDecimal("0");

            if (destinationRow < destinationCol) {
                while (currentRow != 0) {
                    if (currentRow % 2 == 0) {
                        isLukanka = true;
                    } else {
                        isLukanka = false;
                    }
                    // CURRENT PRICE
                    if (isLukanka) {
                        currentPrice = lukankaPrice;
                    } else {
                        currentPrice = rakijaPrice;
                    }
                    //CALCULATE RECHNUNG
                    currentRechnung = BigDecimal.valueOf((currentRow + 1) * (currentCol + 1) * currentPrice);
                    rechnung = rechnung.add(currentRechnung);
                    currentRechnung = new BigDecimal("0");

                    currentRow--;
                }
                while (currentCol != 0) {
                    if (currentRow % 2 == 0) {
                        isLukanka = true;
                    } else {
                        isLukanka = false;
                    }
                    // CURRENT PRICE
                    if (isLukanka) {
                        currentPrice = lukankaPrice;
                    } else {
                        currentPrice = rakijaPrice;
                    }
                    //CALCULATE RECHNUNG
                    currentRechnung = BigDecimal.valueOf((currentRow + 1) * (currentCol + 1) * currentPrice);
                    rechnung = rechnung.add(currentRechnung);
                    currentRechnung = new BigDecimal("0");

                    currentCol--;
                }
            } else {
                while (currentCol != 0) {
                    if (currentRow % 2 == 0) {
                        isLukanka = true;
                    } else {
                        isLukanka = false;
                    }
                    // CURRENT PRICE
                    if (isLukanka) {
                        currentPrice = lukankaPrice;
                    } else {
                        currentPrice = rakijaPrice;
                    }
                    //CALCULATE RECHNUNG
                    currentRechnung = BigDecimal.valueOf((currentRow + 1) * (currentCol + 1) * currentPrice);
                    rechnung = rechnung.add(currentRechnung);
                    currentRechnung = new BigDecimal("0");

                    currentCol--;
                }
                while (currentRow != 0) {
                    if (currentRow % 2 == 0) {
                        isLukanka = true;
                    } else {
                        isLukanka = false;
                    }
                    // CURRENT PRICE
                    if (isLukanka) {
                        currentPrice = lukankaPrice;
                    } else {
                        currentPrice = rakijaPrice;
                    }
                    //CALCULATE RECHNUNG
                    currentRechnung = BigDecimal.valueOf((currentRow + 1) * (currentCol + 1) * currentPrice);
                    rechnung = rechnung.add(currentRechnung);
                    currentRechnung = new BigDecimal("0");

                    currentRow--;
                }
            }
            destination = sc.nextLine();
        }
        System.out.println(rechnung.setScale(6, RoundingMode.HALF_EVEN));
        System.out.println(customerCount);
    }
}
