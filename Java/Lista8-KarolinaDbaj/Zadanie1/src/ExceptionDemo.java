public class ExceptionDemo {

    public static void main(String[] args) {
        // Przykład 1: NullPointerException
        try {
            String text = null;
            System.out.println(text.length());
        } catch (NullPointerException e) {
            System.out.println("Wyjątek: " + e);
        }

        // Przykład 2: ArithmeticException
        try {
            int result = 42 / 0;
            System.out.println(result);
        } catch (ArithmeticException e) {
            System.out.println("Wyjątek: " + e);
        }

        // Przykład 3: ArrayIndexOutOfBoundsException
        try {
            int[] numbers = {1, 2, 3};
            System.out.println(numbers[3]);
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Wyjątek: " + e);
        }
    }
}