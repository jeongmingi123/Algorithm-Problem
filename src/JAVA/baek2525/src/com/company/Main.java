package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        // write your code here
        Scanner scan = new Scanner(System.in);
        int startHour = scan.nextInt();
        int startMinute = scan.nextInt();
        int addingMinute = scan.nextInt();

        Oven oven = new Oven(startHour, startMinute);
        System.out.println(oven.CalculateCompletedTimeBy(addingMinute));
    }
}

class Oven {

    private int hour;
    private int minute;

    public Oven(int hour, int minute) {
        this.hour = hour;
        this.minute = minute;
    }

    public String CalculateCompletedTimeBy(int addingMinute) {
        int addingHours = 0;

        if (addingMinute >= 60) {
            addingHours = addingMinute / 60;
            addingMinute = addingMinute % 60;
        }

        this.hour += addingHours;
        this.minute += addingMinute;

        if (this.minute >= 60) {
            this.minute -= 60;
            ++this.hour;
        }

        if (this.hour >= 24) {
            this.hour = this.hour % 24;
        }

        String result = String.format("%d %d", this.hour, this.minute);
        return result;
    }
}