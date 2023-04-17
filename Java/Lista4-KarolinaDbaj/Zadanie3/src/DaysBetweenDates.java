
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;

public class DaysBetweenDates {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        DateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");

        // pobranie daty początkowej od użytkownika
        System.out.print("Podaj datę początkową w formacie RRRR-MM-DD: ");
        String startDateStr = scanner.nextLine();
        Date startDate = null;
        try {
            startDate = dateFormat.parse(startDateStr);//konwertujemy na obiekt typu Date
        } catch (ParseException e) {
            System.out.println("Nieprawidłowy format daty początkowej.");
            return;
        }

        // pobranie daty końcowej od użytkownika
        System.out.print("Podaj datę końcową w formacie RRRR-MM-DD: ");
        String endDateStr = scanner.nextLine();
        Date endDate = null;
        try {
            endDate = dateFormat.parse(endDateStr);
        } catch (ParseException e) {
            System.out.println("Nieprawidłowy format daty końcowej.");
            return;
        }

        // obliczenie różnicy między datami w dniach
        long diffInMillies = Math.abs(endDate.getTime() - startDate.getTime());
        long diffInDays = diffInMillies / (24 * 60 * 60 * 1000);

        System.out.println("Liczba dni między datami: " + diffInDays);
    }
}