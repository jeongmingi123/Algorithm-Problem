package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int testCase = scan.nextInt();

        int[] nums = new int[testCase];
        for (int i = 0; i < testCase; i++) {
            nums[i] = scan.nextInt();
        }

        int min = Math.getMin(nums);
        int max = Math.getMax(nums);

        String result = String.format("%d %d", min, max);
        System.out.println(result);
    }
}

class Math {

    private Math() {
    }

    static int getMin(int[] nums) {

        if (nums.length == 1) {
            return nums[0];
        }

        int min = nums[0];
        for (int i = 1; i < nums.length; i++) {
            if (min > nums[i]) {
                min = nums[i];
            }
        }

        return min;
    }

    static int getMax(int[] nums) {

        if (nums.length == 1) {
            return nums[0];
        }

        int max = nums[0];
        for (int i = 1; i < nums.length; i++) {
            if (max < nums[i]) {
                max = nums[i];
            }
        }

        return max;
    }
}
