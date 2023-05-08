import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class TabliczkaMnozenia {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Podaj liczbę naturalną n: ");
        int n = scanner.nextInt(); // Wczytujemy liczbę naturalną n od użytkownika

        // Tworzymy ArrayList przechowujący wyniki mnożenia
        List<List<Integer>> tabliczka = new ArrayList<>();

        for (int i = 1; i <= n; i++) {
            List<Integer> wiersz = new ArrayList<>();
            for (int j = 1; j <= n; j++) {
                wiersz.add(i * j);
            }
            tabliczka.add(wiersz);
        }

        // Wypisujemy tabliczkę mnożenia
        for (List<Integer> wiersz : tabliczka) {
            for (int j = 0; j < n; j++) {
                int wynik = wiersz.get(j);
                int szerokosc = szerokoscKolumny(n, j + 1);
                System.out.printf("%" + szerokosc + "d", wynik);
            }
            System.out.println();
        }

        scanner.close();
    }

    public static int szerokoscKolumny(int n, int kolumna) {
        int najwiekszaLiczba = n * kolumna;
        int dlugosc = Integer.toString(najwiekszaLiczba).length();
        return dlugosc + 1;
    }
}