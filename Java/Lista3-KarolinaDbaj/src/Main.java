import java.util.Scanner;

public class Main {


        public static void main(String[] args) {
            Scanner input = new Scanner(System.in);
            System.out.print("Podaj pierwsze slowo: ");
            String slowo1 = input.nextLine();
            System.out.print("Podaj drugie slowo: ");
            String slowo2 = input.nextLine();

            boolean czyJestPodslowem = false;

            for (int i = 0; i <= slowo2.length() - slowo1.length(); i++) {
                if (slowo2.charAt(i) == slowo1.charAt(0)) {
                    czyJestPodslowem = true;
                    for (int j = 1; j < slowo1.length(); j++) {
                        if (slowo2.charAt(i + j) != slowo1.charAt(j)) {
                            czyJestPodslowem = false;
                            break;
                        }
                    }
                    if (czyJestPodslowem) {
                        break;
                    }
                }
            }

            if (czyJestPodslowem) {
                System.out.println(slowo1 + " jest podsłowem " + slowo2);
            } else {
                System.out.println(slowo1 + " nie jest podsłowem " + slowo2);
            }
        }


}