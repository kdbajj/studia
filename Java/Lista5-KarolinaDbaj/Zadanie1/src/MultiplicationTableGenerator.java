import java.util.Scanner;

public class MultiplicationTableGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a natural number n: ");
        int naturalNumber = scanner.nextInt();

        // Calculate column width based on the largest multiplication result
        int columnWidth = Integer.toString(naturalNumber * naturalNumber).length() + 1;

        for (int i = 0; i <= naturalNumber; i++) {
            for (int j = 0; j <= naturalNumber; j++) {
                if (i == 0 && j == 0) {
                    System.out.printf("%" + columnWidth + "s", "");
                } else if (i == 0) {
                    System.out.printf("%" + columnWidth + "d", j);
                } else if (j == 0) {
                    System.out.printf("%" + columnWidth + "d", i);
                } else {
                    System.out.printf("%" + columnWidth + "d", i * j);
                }
            }
            System.out.println();
        }
    }
}