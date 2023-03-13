import java.util.Scanner;

public class Nauczyciel {
    public static void main(String[] args) {
//        Uczen uczen1 = new Uczen();//inicjalizacja klasy
//        uczen1.setImie("ania");
//        Uczen.numerKursu = 222;
//        uczen1.setOcena(5);
//        Uczen uczen2 = new Uczen();
//        uczen2.setImie("ala");
//        uczen2.setOcena(4);
//        Uczen uczen3 = new Uczen("karolina");

        Scanner scanner = new Scanner(System.in);

        System.out.print("Podaj imię: ");
        String name= scanner.next();
        System.out.print("Podaj ocenę: ");
        int ocena=  Integer.parseInt(scanner.next());
        System.out.print("Podaj ulubiony kolor: ");
        String ulubionyKolor= scanner.next();
        System.out.print("Podaj rok rozpoczęcia kursu: ");
        String rok= scanner.next();


        System.out.println("=========");
        System.out.println("imię: "+ name);
        System.out.println("ocena: "+ ocena);
        System.out.println("ulubiony kolor: "+ ulubionyKolor);
        System.out.println("rok rozpoczęcia kursu: "+ rok);

//
//        System.out.println(uczen3.getImie());
//        System.out.println(uczen1.getImie());
//        System.out.println(Uczen.numerKursu);
//        System.out.println(uczen1.getOcena());
//        System.out.println(uczen2.getImie());
//        System.out.println(Uczen.numerKursu);
//        System.out.println(uczen2.getOcena());
    }
    //6.
    //dzięki static zyskaliśmy możliwość odwoływania się do zmiennej bez
    //inicjalizacji klasy

    //dzięki akcesorowi i mutatorowi możemy odwołać się do instancji
    //zmiennej

}


