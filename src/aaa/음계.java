import java.util.Scanner;

public class 음계 {

    public static void main(String[] args) {
        // TODO Auto-generated method stub
        Scanner scan = new Scanner(System.in);

        int[] arr = new int[8];

        int j = 8;
        boolean asCheck = true;
        boolean dsCheck = true;

        for (int i = 0; i < arr.length; i++)
            arr[i] = scan.nextInt();

        if (arr[0] == 1) {
            for (int i = 1; i < arr.length; i++) {
                if (arr[i] != i+1)
                    asCheck = false;
            }
            System.out.println(asCheck == true ? "ascending" : "mixed");
        } else if (arr[0] == 8) {
            for (int i = 1; i < arr.length; i++) {
                if (arr[i] != j - i) {
                    dsCheck = false;
                }
            }
            System.out.println(dsCheck == true ? "descending" : "mixed");
        } else if (arr[0] != 1 && arr[0] != 8)
            System.out.println("mixed");

    }

}