import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/**
 * Created by user on 08.04.2016.
 */
public class CsvDatabase {
    public static void main(String[] args) {

        HashMap<Integer, String> studentFirstName = new HashMap<>();
        HashMap<Integer, String> studentLastName = new HashMap<>();
        HashMap<Integer, Integer> studentAge = new HashMap<>();
        HashMap<Integer, String> studentAddress = new HashMap<>();

        HashMap<Integer, HashMap<String, ArrayList<Double>>> studentGrades = new HashMap<>();
        HashMap<String, ArrayList<Double>> courseGrades = new HashMap<>();
        ArrayList<Double> gradesList = new ArrayList<Double>(){{
            add(2d);
            add(2.5);
        }};

        Integer studentID = 1;
        String firstName = "";
        String lastName = "";
        String address = "";
        Integer age = 0;
        String courses = "";
        Double grade = 0d;


        // put student
        studentFirstName.put(studentID, firstName);
        studentLastName.put(studentID, lastName);
        studentAge.put(studentID, age);
        studentAddress.put(studentID, address);

        // put grades

    }
}
