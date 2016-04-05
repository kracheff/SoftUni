import java.io.*;

/**
 * Created by user on 29.03.2016.
 */
public class SumLines {
    public static void main(String[] args) {
        File file = new File ("Resources/lines.txt");

        try (
            BufferedReader in = new BufferedReader(new FileReader(file));
            BufferedWriter out = new BufferedWriter(new FileWriter("Resources/sum_lines.txt"))
        ){
            String line = "";
            while ((line = in.readLine()) != null){
                int charSum = 0;

                for (int i = 0; i < line.length(); i++) {
                    charSum += line.charAt(i);
                }
                out.write("Sum of line chars " + charSum + "\n");
                System.out.println(charSum);
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }


    }
}
