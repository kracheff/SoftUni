package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int[] numArr = Arrays.stream(sc.nextLine().split("\\s+")).mapToInt(Integer::parseInt).toArray();
        String[] command = sc.nextLine().split("\\s+");
        int count = Integer.parseInt(command[1]);
        List<Integer> integerList = new ArrayList<>();

        switch (command[2]) {

            case "odd":
                if (count > numArr.length) {

                    for (int i = 0; i < numArr.length; i++) {

                        if (numArr[i] % 2 != 0) {


                            integerList.add(numArr[i]);

                        }
                    }
                } else {

                    for (int i = 0; i < numArr.length; i++) {

                        if (numArr[i] % 2 != 0) {


                            integerList.add(numArr[i]);

                        }
                        if (integerList.size() == count) {

                            break;
                        }

                    }

                }
                break;
            case "even":
                if (count > numArr.length) {

                    for (int i = 0; i < numArr.length; i++) {

                        if (numArr[i] % 2 == 0) {


                            integerList.add(numArr[i]);

                        }
                    }
                } else {

                    for (int i = 0; i < numArr.length; i++) {

                        if (numArr[i] % 2 == 0) {


                            integerList.add(numArr[i]);

                        }
                        if (integerList.size() == count) {

                            break;
                        }

                    }

                }
                break;
        }

        System.out.println(integerList);
    }


}
