public class Uczen {

    public String getImie() {
        return imie;
    }

    public void setImie(String imie) {
        this.imie = imie;
    }

    private String imie;
    public static int numerKursu;
    public final int rok =44;
    private int ocena;
    public  String ulubionyKolor = "fioletowy";

    public String getUlubionyKolor() {
        return ulubionyKolor;
    }

    public void setUlubionyKolor(String ulubionyKolor) {
        this.ulubionyKolor = ulubionyKolor;
    }

    public int getOcena() {
        return ocena;
    }

    public void setOcena(int ocena) {
        this.ocena = ocena;
    }
    public Uczen (){

    }

    public Uczen(String imie){
        setImie(imie);
    }
    public Uczen(String imie, int ocena) {
        setImie(imie);
        setOcena(ocena);
    }
    public Uczen(String imie, int ocena, String ulubionyKolor, int rok){
        setImie(imie);
        setOcena(ocena);
        setUlubionyKolor(ulubionyKolor);
    }
}

