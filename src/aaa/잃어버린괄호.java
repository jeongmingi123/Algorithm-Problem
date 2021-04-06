import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class 잃어버린괄호 {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String[] itemMinus = br.readLine().split("-");

        int total = 0;

        for (int i = 0; i < itemMinus.length; i++) {

            int temp = 0;
            int first = Integer.parseInt(itemMinus[0]);

            String[] itemPlus = itemMinus[i].split("\\+");
            for (int j = 0; j < itemPlus.length; j++) {
                temp += Integer.parseInt(itemPlus[j]);
            }

            if (temp == first) {
                total += first;
            } else {
                total -= temp;
            }
        }

        System.out.println(total);


    }

}
