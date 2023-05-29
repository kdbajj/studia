import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        int numElements = 100000;

        List<Integer> arrayList = new ArrayList<>();
        List<Integer> linkedList = new LinkedList<>();

        long startTime, endTime;

        // Dodawanie elementów do ArrayList
        startTime = System.nanoTime();
        for (int i = 0; i < numElements; i++) {
            arrayList.add(i);
        }
        endTime = System.nanoTime();
        System.out.println("Czas dodawania elementów do ArrayList: " + (endTime - startTime) + " ns");

        // Dodawanie elementów do LinkedList
        startTime = System.nanoTime();
        for (int i = 0; i < numElements; i++) {
            linkedList.add(i);
        }
        endTime = System.nanoTime();
        System.out.println("Czas dodawania elementów do LinkedList: " + (endTime - startTime) + " ns");

        // Wyszukiwanie elementów w ArrayList
        startTime = System.nanoTime();
        for (int i = 0; i < numElements; i++) {
            arrayList.get(i);
        }
        endTime = System.nanoTime();
        System.out.println("Czas wyszukiwania elementów w ArrayList: " + (endTime - startTime) + " ns");

        // Wyszukiwanie elementów w LinkedList
        startTime = System.nanoTime();
        for (int i = 0; i < numElements; i++) {
            linkedList.get(i);
        }
        endTime = System.nanoTime();
        System.out.println("Czas wyszukiwania elementów w LinkedList: " + (endTime - startTime) + " ns");
    }
}