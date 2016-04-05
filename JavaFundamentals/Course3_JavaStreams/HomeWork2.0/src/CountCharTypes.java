import java.io.*;

/**
 * Created by user on 29.03.2016.
 */
public class CountCharTypes {
    public static void main(String[] args) throws IOException {
        File file = new File("resources/words.txt");
        int vowelsCount = 0;
        int consonantsCount = 0;
        int punctuationCount = 0;


        try (BufferedReader in = new BufferedReader(new FileReader(file));
        ){
            char c;
            while ((c = (char)in.read()) != 65535){
                if (c == 'a' ||
                    c == 'e' ||
                    c == 'i' ||
                    c == 'o' ||
                    c == 'u') {
                    vowelsCount++;
                } else if (c == '!' ||
                    c == ',' ||
                    c == '.' ||
                    c == '?') {
                    punctuationCount++;
                } else if (c != ' ') {
                    consonantsCount++;
                }
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        BufferedWriter out = new BufferedWriter(new FileWriter("resources/count-chars.txt"));
        out.write("Vowels: " + vowelsCount + "\n" +
                "Consonants: " + consonantsCount + "\n" +
                "Punctuation: " + punctuationCount + "\n");
        out.close();
    }
}

