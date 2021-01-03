import java.util.Scanner;

public class 알람시계 {

    public static void main(String[] args) {
        // TODO Auto-generated method stub

        Scanner scan = new Scanner(System.in);

        int hour = scan.nextInt();
        int min = scan.nextInt();

        if (hour == 0 && min < 45) {
            min = min + 60 - 45;
            hour = 23;
        } else if (hour == 0 && min >= 45)
            min -= 45;
        else if (hour != 0 && min < 45) {
            hour -= 1;
            min = min + 60 - 45;
        } else if (hour != 0 && min >= 45)
            min -= 45;

        System.out.println(hour + " " + min);

    }

}