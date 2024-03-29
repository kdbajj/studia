import java.util.Scanner;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class DateListManager {
    private static final int MAX_SIZE = 10;
    private List<String> dates = new ArrayList<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        DateListManager manager = new DateListManager();

        while (true) {
            System.out.print("Podaj date w formacie dd-mm-yyyy (, naciśnij q aby wyjsc): ");
            String input = scanner.nextLine();

            if (input.equalsIgnoreCase("q")) {
                break;
            }

            if (!manager.isValidDate(input)) {
                System.out.println("Niepoprawny format daty.");
                continue;
            }

            if (manager.dates.contains(input)) {
                System.out.println("Ta data juz istnieje.");
                continue;
            }

            manager.addDate(input);

            System.out.println("Lista dat: ");
            manager.printDates();
        }
    }

    public void addDate(String date) {
        dates.add(date);
        if (dates.size() > MAX_SIZE) { // jeśli lista przekroczyła maksymalną liczbę elementów
            dates.remove(0);
        }
        sortDates();
    }

    public void removeDate(String date) {
        dates.remove(date);
    }

    public void printDates() {
        System.out.println(dates);
    }

    private void sortDates() {
        Collections.sort(dates, (date1, date2) -> {
            String[] parts1 = date1.split("-");
            String[] parts2 = date2.split("-");
            int year1 = Integer.parseInt(parts1[2]);
            int year2 = Integer.parseInt(parts2[2]);
            int month1 = Integer.parseInt(parts1[1]);
            int month2 = Integer.parseInt(parts2[1]);
            int day1 = Integer.parseInt(parts1[0]);
            int day2 = Integer.parseInt(parts2[0]);
            if (year1 != year2) {
                return Integer.compare(year1, year2);
            } else if (month1 != month2) {
                return Integer.compare(month1, month2);
            } else {
                return Integer.compare(day1, day2);
            }
        });
    }

    private boolean isValidDate(String input) {
        String[] parts = input.split("-");
        if (parts.length != 3) {
            return false;
        }
        try {
            int day = Integer.parseInt(parts[0]);
            int month = Integer.parseInt(parts[1]);
            int year = Integer.parseInt(parts[2]);
            if ((day < 1) || (day > 31) || (month < 1) || (month > 12) || (year < 1)) {
                return false;
            }
        } catch (NumberFormatException e) {
            return false;
        }
        return true;
    }
}