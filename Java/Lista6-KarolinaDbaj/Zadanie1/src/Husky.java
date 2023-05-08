public class Husky extends Pies {
    public Husky(String imie) {
        super(imie);
    }

    public Husky() {
        this("Husky");
    }

    @Override
    public String toString() {
        return "Husky o imieniu " + imie;
    }
}