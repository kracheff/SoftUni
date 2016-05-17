import java.util.Scanner;

public class CollectResources {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String resourceField = sc.nextLine();
        int numberOfPaths = Integer.parseInt(sc.nextLine());
        int maxNumberOfResources = 0;

        String[] resourceElements = resourceField.split(" ");

        for (int i = 0; i < numberOfPaths; i++) {
            String[] path = sc.nextLine().split(" ");
            int startIndex = Integer.parseInt(path[0]);
            int step = Integer.parseInt(path[1]);
            int currentPos = startIndex;
            int nextPos = 0;
            int currentNumberOfResources = 0;

            while (!"0".equals(resourceElements[currentPos])) {
                String[] fieldResources = resourceElements[currentPos].split("_");

                boolean isValidResource =
                        fieldResources[0].equals("stone") ||
                                fieldResources[0].equals("gold") ||
                                fieldResources[0].equals("wood") ||
                                fieldResources[0].equals("food");

                if (isValidResource) {
                    if (fieldResources.length == 1) {
                        String tempRes = "";
                        tempRes = fieldResources[0];
                        fieldResources = new String[2];
                        fieldResources[0] = tempRes;
                        fieldResources[1] = "1";
                    }
                    currentNumberOfResources += Integer.parseInt(fieldResources[1]);
                    resourceElements[currentPos] = "0";
                }
                nextPos = (currentPos + step) % resourceElements.length;
                currentPos = nextPos;
            }
            if (currentNumberOfResources > maxNumberOfResources) {
                maxNumberOfResources = currentNumberOfResources;
            }
            resourceElements = resourceField.split(" ");
        }
        System.out.println(maxNumberOfResources);
    }
}