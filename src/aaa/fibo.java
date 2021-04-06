import java.util.Scanner;

public class fibo {

    public static int fibona(int n){
        if (n==0) return 0;
        if (n==1) return 1;
        else{
            return fibona(n-1)+fibona(n-2);
        }
    }

    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        System.out.println(fibona(n));

    }
}
