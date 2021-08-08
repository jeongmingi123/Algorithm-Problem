package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        // write your code here

        Scanner scan = new Scanner(System.in);
        int num = scan.nextInt();
        for (int i = num; 0 < i; --i) {
            System.out.println(i);
        }
    }
}
