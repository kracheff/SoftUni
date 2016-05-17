import java.util.Scanner;

/**
 * Created by user on 06.05.2016.
 */
public class ParkingSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] dimentions = sc.nextLine().split(" ");
        int rows = Integer.parseInt(dimentions[0]);
        int cols = Integer.parseInt(dimentions[1]);

        boolean[][] matrix = new boolean[rows][cols];

        String command = sc.nextLine();

        if (command.equals("stop")){
            System.out.println("0");
        }

        while (!command.equals("stop")) {

                        String[] parkingParameters = command.split(" ");                   // what if first command is STOP?
            int startingRow = Integer.parseInt(parkingParameters[0]);
            int startingCol = 0;
            int destinationRow = Integer.parseInt(parkingParameters[1]);
            int destinationCol = Integer.parseInt(parkingParameters[2]);
            boolean isParked = false;
            int travelledDistance = 0;

            if (destinationCol == 0){
                System.out.println("0");
                command = sc.nextLine();
                continue;
            }

            if (matrix[destinationRow][destinationCol] == false && destinationCol != 0) {
                matrix[destinationRow][destinationCol] = true;
                isParked = true;
                travelledDistance = Math.abs(startingRow - destinationRow) + Math.abs(startingCol - destinationCol) + 1;
            } else {
                for (int i = 1; i <= Math.max((cols - destinationCol), destinationCol-1); i++) {
                    if (matrix[destinationRow][Math.max((destinationCol - i), 0)] == false && (Math.max((destinationCol - i), 0)) != 0) {
                        matrix[destinationRow][Math.max((destinationCol - i), 0)] = true;
                        isParked = true;
                        travelledDistance = Math.abs(startingRow - destinationRow) + Math.abs(startingCol - (Math.max((destinationCol - i), 0))) + 1;
                        break;
                    }
                    else {
                        if (matrix[destinationRow][Math.min((destinationCol + i), cols-1)] == false && (Math.min((destinationCol + i), cols-1)) != 0) {
                            matrix[destinationRow][Math.min((destinationCol + i), cols-1)] = true;
                            isParked = true;
                            travelledDistance = Math.abs(startingRow - destinationRow) + Math.abs(startingCol - (Math.min((destinationCol + i), cols-1))) + 1;
                            break;
                        }
                    }
                }
            }

            if (isParked == false) {
                System.out.println("Row " + destinationRow + " full");
            } else {
                System.out.println(travelledDistance);
            }
            command = sc.nextLine();
        }

//        for (int i = 0; i < rows; i++) {
//            for (int j = 0; j < cols; j++) {
//                System.out.print(matrix[i][j] + " ");
//            }
//            System.out.println();
//        }

    }
}
