import java.math.BigInteger;
import java.util.*;

/**
 * Created by user on 26.04.2016.
 */
public class CriticalBreakpoit {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] inputArr;
        int countOfLines = 1;                                           // Може ли да има инпут само с един ред?

        if (input.equals("Break it.")) {
            System.out.println("Critical breakpoint does not exist.");
            System.exit(0);
        }

        TreeMap<Integer, LinkedList<Long>> allLines = new TreeMap<>();
        LinkedList<Long> coordinates = new LinkedList<>();

        while (!input.equals("Break it.")) {

            inputArr = input.split(" ");

            long x1 = Long.parseLong(inputArr[0]);
            long y1 = Long.parseLong(inputArr[1]);
            long x2 = Long.parseLong(inputArr[2]);
            long y2 = Long.parseLong(inputArr[3]);

            long criticalBreakpoint = 0;

            coordinates = new LinkedList<>();
            coordinates.add(x1);
            coordinates.add(y1);
            coordinates.add(x2);
            coordinates.add(y2);

            allLines.put(countOfLines, coordinates);

            input = sc.nextLine();
            if (!input.equals("Break it.")) {
                countOfLines++;
            }
        }
        LinkedList<Long> breakpoints = new LinkedList<>();

        for (Map.Entry<Integer, LinkedList<Long>> line : allLines.entrySet()) {
            coordinates = line.getValue();
            long criticalBreakpoint = Math.abs(coordinates.get(0) + coordinates.get(1) - coordinates.get(2) - coordinates.get(3));
            breakpoints.add(criticalBreakpoint);
        }

        boolean criticalBreakpointExists = true;
        boolean currentIterration;

        for (int i = 0; i < breakpoints.size(); i++) {
            for (int j = i + 1; j < breakpoints.size(); j++) {
                if (Objects.equals(breakpoints.get(i), breakpoints.get(j)) || breakpoints.get(i) == 0 || breakpoints.get(j) == 0) {
                    currentIterration = true;
                    criticalBreakpointExists &= currentIterration;
                } else {
                    criticalBreakpointExists = false;
                }
            }
        }
        long criticalRatio = 0;


        if (criticalBreakpointExists == false) {
            System.out.println("Critical breakpoint does not exist.");
        } else {
            for (int i = 0; i < breakpoints.size(); i++) {
                if (breakpoints.get(i) != 0) {
                    criticalRatio = breakpoints.get(i);
                    break;
                }
            }

            BigInteger criticalBreakpoint = new BigInteger("" + criticalRatio);
            criticalBreakpoint = criticalBreakpoint.pow(countOfLines);
            BigInteger devisor = new BigInteger("" + countOfLines);
            criticalBreakpoint = criticalBreakpoint.remainder(devisor);

            for (Map.Entry<Integer, LinkedList<Long>> line : allLines.entrySet()) {
                System.out.print("Line: ");
                System.out.println(line.getValue());
            }
            System.out.println("Critical Breakpoint: " + criticalBreakpoint);
        }
    }
}
