public class hapEx {

    public static int hap(int n) {
        if (n == 0) return 0;
        else {
            return n + hap(n - 1);
        }
    }


    public static void main(String[] args) {

        int n = 100;
        System.out.println(hap(100));
        ;
    }

}
