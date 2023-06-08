public class SynchronizedExample {

    // Wspólna zmienna dla obiektów wątków
    private int licznik = 0;

    public static void main(String[] args) {
        SynchronizedExample example = new SynchronizedExample();
        example.runExample();
    }

    public void runExample() {
        // Utwórz dwa wątki, które będą próbować zwiększyć wartość licznika
        Thread thread1 = new Thread(() -> {
            for (int i = 0; i < 10000; i++) {
                incrementCounter();
            }
        });

        Thread thread2 = new Thread(() -> {
            for (int i = 0; i < 10000; i++) {
                incrementCounter();
            }
        });

        // Uruchom wątki
        thread1.start();
        thread2.start();

        // Poczekaj na zakończenie wątków
        try {
            thread1.join();
            thread2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        // Wyświetl końcową wartość licznika
        System.out.println("Końcowa wartość licznika: " + licznik);
    }

    // Synchronizowana metoda do zwiększania wartości licznika
    private synchronized void incrementCounter() {
        licznik++;
    }
}
