public class Delfin extends Zwierze implements Ssak, Wodne {
    public Delfin(String imie) {
        super(imie);
    }

    @Override
    public void glos() {
        System.out.println("Klik klik");
    }

    @Override
    public void oddychaj() {
        System.out.println("Delfin oddycha");
    }

    @Override
    public void plywaj() {
        System.out.println("Delfin płynie");
    }
}