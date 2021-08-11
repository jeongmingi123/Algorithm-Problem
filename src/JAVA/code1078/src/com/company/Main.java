package com.company;

import java.util.Scanner;

public class Main {


    public static int getTotalOddsRecursive(int start, int end) {
        if (start == end + 1) {
            return 0;
        }

        if (start % 2 == 0) {
            return start + getTotalOddsRecursive(start + 1, end);
        }

        if (start % 2 != 0) {
            return getTotalOddsRecursive(start + 1, end);
        }

        return 0;
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num = scan.nextInt();
        System.out.println(getTotalOddsRecursive(1, num));

    }
}
