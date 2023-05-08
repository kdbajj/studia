public class Pies extends Zwierze implements Ssak, Ladowe {
    public Pies(String imie) {
        super(imie);
    }

    @Override
    public void glos() {
        System.out.println("Hau hau");
    }

    @Override
    public void oddychaj() {
        System.out.println("Pies oddycha");
    }

    @Override
    public void biegaj() {
        System.out.println("Pies biega");
    }
}