import java.util.ArrayList;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by user on 08.05.2016.
 */
public class RoyalAccounting {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Pattern p = Pattern.compile("([a-zA-Z]+);([0-9]+);([0-9]+.*[0-9]+);([a-zA-Z]+)");

        //       Teams     Employees
        TreeMap<String, ArrayList<String>> teams = new TreeMap<>();
        //     Employee  workHoursPerDay
        TreeMap<String, Byte> employeeWorkDailyHours = new TreeMap<>();
        //     Employee dailyPayment
        TreeMap<String, Double> employeeDailyPayment = new TreeMap<>();

        String input;
        while (!"Pishi kuf i da si hodim".equals(input = sc.nextLine())){

            Matcher m = p.matcher(input);

            while (m.find()){
                String employee = m.group(1);
                byte workHoursPerDay = Byte.parseByte(m.group(2));
                double dailyPayment = Double.parseDouble(m.group(3));
                String team = m.group(4);

                if (!teams.containsKey(team)){
                    teams.put(team, new ArrayList<>());
                }
                teams.get(team).add(employee);

                employeeWorkDailyHours.put(employee, workHoursPerDay);
                employeeDailyPayment.put(employee, dailyPayment);
            }

        }
//        System.out.println("Teams:");
//        System.out.println(teams);
//        System.out.println();
//
//        System.out.println("DailyHours:");
//        System.out.println(employeeWorkDailyHours);
//        System.out.println();
//        System.out.println("Daily Payment");
//        System.out.println(employeeDailyPayment);

        TreeMap<String, Double> employeeMonthlyPayment = new TreeMap<>();

        for (Map.Entry<String, Double> emp : employeeDailyPayment.entrySet()) {
           double monthlyPayment = ((emp.getValue() * employeeWorkDailyHours.get(emp.getKey())) / 24) * 30;
            employeeMonthlyPayment.put(emp.getKey(), monthlyPayment);
        }

        TreeMap<String, Double> employeeDailyIncome = new TreeMap<>();
        for (Map.Entry<String, Double> emp : employeeDailyPayment.entrySet()) {
            double dailyIncome = (emp.getValue() * employeeWorkDailyHours.get(emp.getKey())) / 24;
            employeeDailyIncome.put(emp.getKey(), dailyIncome);
        }


//        System.out.println();
//        System.out.println("Monthly Payment");
//        System.out.println(employeeMonthlyPayment);
//
//        System.out.println();
//        System.out.println("Daily Income");
//        System.out.println(employeeDailyIncome);


    }
}
