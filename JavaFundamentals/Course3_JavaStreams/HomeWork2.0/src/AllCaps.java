import java.io.*;
import java.util.ArrayList;

/**
 * Created by user on 29.03.2016.
 */
public class AllCaps {
    public static void main(String[] args) {
        File file = new File("Resources/lines.txt");
        ArrayList<String> updatedLines = new ArrayList<>();

        try
            (BufferedReader in = new BufferedReader(new FileReader(file));
            ){
            String line = "";

            while ((line = in.readLine()) != null){
                line = line.toUpperCase();
                updatedLines.add(line);
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }

        try (BufferedWriter out = new BufferedWriter(new FileWriter(file));
        ){
            for (int i = 0; i < updatedLines.size(); i++) {
                System.out.println(updatedLines.get(i));
                out.write(updatedLines.get(i) + "\n");
            }

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
