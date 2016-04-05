import java.io.*;

/**
 * Created by user on 29.03.2016.
 */
public class CopyJpgFile {
    public static void main(String[] args) {
        File original = new File("Resources/GTA3.jpg");
        File copyOfOriginal = new File("Resources/GTA3_Copy.jpg");

        try (FileInputStream in = new FileInputStream(original);
             FileOutputStream out = new FileOutputStream(copyOfOriginal);
                ){
            int c;
            while ((c = in.read()) != -1){
                out.write(c);
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }


    }
}
