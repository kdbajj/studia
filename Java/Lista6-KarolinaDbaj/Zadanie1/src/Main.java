public class Main {
    public static void main(String[] args) {
        Husky husky = new Husky("Max");
        Chihuahua chihuahua = new Chihuahua("Bella");
        Delfin delfin = new Delfin("Flipper");

        husky.glos();
        husky.oddychaj();
        husky.biegaj();
        System.out.println(husky);

        chihuahua.glos();
        chihuahua.oddychaj();
        chihuahua.biegaj();

        delfin.glos();
        delfin.oddychaj();
        delfin.plywaj();
    }
}