import java.util.*;

public class LogsAggregator {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int lines = sc.nextInt();

        TreeMap<String, List<Integer>> userDuration = new TreeMap<>();
        TreeMap<String, Set<String>> userIPs = new TreeMap<>();

        sc.nextLine();

        for (int i = 0; i < lines; i++) {
            String[] input = sc.nextLine().split(" ");

            Set<String> ipList = userIPs.get(input[1]);
            List<Integer> durationList = userDuration.get(input[1]);

            if (ipList == null) {
                ipList = new TreeSet<>();
            }
            ipList.add(input[0]);
            userIPs.put(input[1], ipList);

            if (durationList == null) {
                durationList = new ArrayList<Integer>();
            }
            durationList.add(Integer.parseInt(input[2]));
            userDuration.put(input[1], durationList);
        }

        for (String s : userDuration.keySet()){
            int sum = 0;
            for (Integer integer : userDuration.get(s)) {
                sum += integer;
            }

//            System.out.print(s + ": " + sum + " ");
//            System.out.println(userIPs.get(s));

        }
        System.out.println(userDuration.entrySet());

        for (Map.Entry<String, List<Integer>> listEntry : userDuration.entrySet()) {
            System.out.println(listEntry);
            System.out.println(listEntry.getKey());
            for (String s : userIPs.keySet()) {
                
            }
            System.out.println(listEntry.getValue());
            System.out.println(listEntry.getClass());
        }

    }
}
