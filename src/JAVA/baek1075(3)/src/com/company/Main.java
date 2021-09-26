package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int num = scan.nextInt();
        int f = scan.nextInt();

        num = changeLastTwoDigits(num);
        System.out.println(divide(num, f));
    }

    public static String divide(int num, int f) {
        if (num % f == 0) {
            String result = Integer.toString(num);
            result = result.substring(result.length() - 2, result.length());

            return result;
        }
        return divide(num + 1, f);
    }

    public static int changeLastTwoDigits(int num) {
        int length = (int) (Math.log10(num) + 1);
        int temp = num % 100;
        num = num - temp;

        return num;
    }
}
