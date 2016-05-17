import java.time.LocalTime;
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Events {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int numberOfEvents = Integer.parseInt(sc.nextLine());

        //      location        person   times
        TreeMap<String, TreeMap<String, ArrayList<LocalTime>>> database = new TreeMap<>();

        Pattern p = Pattern.compile("^#([A-Za-z]+): *@([A-Za-z]+) *([0-9]:[0-5][0-9]|[0-1][0-9]:[0-5][0-9]|[2][0-3]:[0-5][0-9])$");

        for (int i = 0; i < numberOfEvents; i++) {

            String event = sc.nextLine();
            Matcher m = p.matcher(event);
            String person;
            String location;
            String stringTime;

            while (m.find()) {
                person = m.group(1); //.substring(1, m.group(1).length() - 1);
                location = m.group(2); //.substring(1);
                stringTime = m.group(3);

                LocalTime time = LocalTime.parse(stringTime);

                if (!database.containsKey(location)) {
                    database.put(location, new TreeMap<>());
                }
                if (!database.get(location).containsKey(person)) {
                    database.get(location).put(person, new ArrayList<>());
                }
                database.get(location).get(person).add(time);
            }
        }
        // System.out.println(database);



        String[] locationsOfInterest = sc.nextLine().split(",");
        ArrayList<String> cities = new ArrayList<>(Arrays.asList(locationsOfInterest));

        for (Map.Entry<String, TreeMap<String, ArrayList<LocalTime>>> databaseEntry : database.entrySet()) {
            if (cities.contains(databaseEntry.getKey())) {
                System.out.println(databaseEntry.getKey() + ":");
                TreeMap<String, ArrayList<LocalTime>> temp = databaseEntry.getValue();
                int serialNumber = 0;
                for (Map.Entry<String, ArrayList<LocalTime>> personAndTimes : temp.entrySet()) {
                    Collections.sort(personAndTimes.getValue());
                    serialNumber += 1;
                    System.out.println((serialNumber) + ". " +
                            personAndTimes.getKey() + " -> " +
                            String.join(", ", personAndTimes.getValue().
                                    toString().
                                    substring(1, personAndTimes.getValue().
                                            toString().
                                            length() - 1)));

                }
            }
        }
    }
}
