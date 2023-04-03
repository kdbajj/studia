import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Podaj swoje dane w formacie: wiek, data urodzenia (dd.MM.rrrr), PESEL, imię i nazwisko lub imiona i nazwisko:");
        String dane = scanner.nextLine();

        String[] daneTab = dane.split(", ");
        int wiek = Integer.parseInt(daneTab[0]);
        String dataUrodzenia = daneTab[1];
        String pesel = daneTab[2];
        String imionaINazwisko = daneTab[3];

        if (imionaINazwisko.contains(" ")) {
            String[] imionaINazwiskoTab = imionaINazwisko.split(" ");
            String imie1 = imionaINazwiskoTab[0];
            String imie2 = imionaINazwiskoTab[1];
            String nazwisko = imionaINazwiskoTab[2];
            wypiszImie1Imie2INazwisko(imie1, imie2, nazwisko);
        } else {
            String[] imieNazwiskoTab = imionaINazwisko.split(" ");
            String imie = imieNazwiskoTab[0];
            String nazwisko = imieNazwiskoTab[1];
            wypiszImieINazwisko(imie, nazwisko);
        }

        wypiszRokUrodzenia(wiek);
        wypiszDateUrodzenia(dataUrodzenia);
        wypiszPesel(pesel);
    }

    private static void wypiszRokUrodzenia(int wiek) {
        int rok = 2023 - wiek;
        System.out.println("Rok urodzenia: " + rok);
    }

    private static void wypiszDateUrodzenia(String dataUrodzenia) {
        String[] dataUrodzeniaTab = dataUrodzenia.split("\\.");
        int dzien = Integer.parseInt(dataUrodzeniaTab[0]);
        int miesiac = Integer.parseInt(dataUrodzeniaTab[1]);
        int rok = Integer.parseInt(dataUrodzeniaTab[2]);
        System.out.println("Urodziłeś/łaś się " + dzien + " " + nazwaMiesiaca(miesiac) + " " + rok + " roku");
    }

    private static String nazwaMiesiaca(int miesiac) {
        switch (miesiac) {
            case 1:
                return "stycznia";
            case 2:
                return "lutego";
            case 3:
                return "marca";
            case 4:
                return "kwietnia";
            case 5:
                return "maja";
            case 6:
                return "czerwca";
            case 7:
                return "lipca";
            case 8:
                return "sierpnia";
            case 9:
                return "września";
            case 10:
                return "października";
            case 11:
                return "listopada";
            case 12:
                return "grudnia";
            default:
                return "";
        }
    }

    private static void wypiszPesel(String pesel) {
        System.out.println("Numer PESEL: " + pesel);
        String rokPesel = pesel.substring(0, 2);
        String miesiacPesel = pesel.substring(2, 4);
        String dzienPesel = pesel.substring(4, 6);
        int rok = Integer.parseInt(rokPesel);
        int miesiac = Integer.parseInt(miesiacPesel);
        int dzien = Integer.parseInt(dzienPesel);
        if (miesiac > 80 && miesiac < 93) {
            rok += 1800;
            miesiac -= 80;
        } else if (miesiac > 0 && miesiac < 13) {
            rok += 1900;
        } else if (miesiac > 20 && miesiac < 33) {
            rok += 2000;
            miesiac -= 20;
        } else if (miesiac > 40 && miesiac < 53) {
            rok += 2100;
            miesiac -= 40;
        } else if (miesiac > 60 && miesiac < 73) {
            rok += 2200;
            miesiac -= 60;
        }
        System.out.println("Data urodzenia: " + dzien + " " + nazwaMiesiaca(miesiac) + " " + rok + " roku");
    }

    private static void wypiszImieINazwisko(String imie, String nazwisko) {
        System.out.println("Imię: " + imie);
        System.out.println("Nazwisko: " + nazwisko);
    }

    private static void wypiszImie1Imie2INazwisko(String imie1, String imie2, String nazwisko) {
        System.out.println("Pierwsze Imię: " + imie1);
        System.out.println("Drugie Imię: " + imie2);
        System.out.println("Nazwisko: " + nazwisko);
    }
}
