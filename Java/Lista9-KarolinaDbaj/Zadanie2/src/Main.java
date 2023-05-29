import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Student> students = new ArrayList<>();

        students.add(new Student(2021, "Kowalski", 4.2));
        students.add(new Student(2020, "Nowak", 3.8));
        students.add(new Student(2021, "Nowak", 4.0));
        students.add(new Student(2020, "Kowalski", 3.6));

        Collections.sort(students);
        for (Student student : students) {
            System.out.println(student);
        }
    }
}

class Student implements Comparable<Student> {
    private int rocznik;
    private String nazwisko;
    private double srednia;

    public Student(int rocznik, String nazwisko, double srednia) {
        this.rocznik = rocznik;
        this.nazwisko = nazwisko;
        this.srednia = srednia;
    }

    public int getRocznik() {
        return rocznik;
    }

    public String getNazwisko() {
        return nazwisko;
    }

    public double getSrednia() {
        return srednia;
    }

    @Override
    public int compareTo(Student other) {
        int rocznikComparison = Integer.compare(this.rocznik, other.rocznik);
        if (rocznikComparison != 0) {
            return rocznikComparison;
        }

        int sredniaComparison = Double.compare(this.srednia, other.srednia);
        if (sredniaComparison != 0) {
            return -sredniaComparison;//sortowanie malejąco
        }

        return this.nazwisko.compareTo(other.nazwisko);
    }

    @Override
    public String toString() {
        return "Student{" +
                "rocznik=" + rocznik +
                ", nazwisko='" + nazwisko + '\'' +
                ", srednia=" + srednia +
                '}';
    }
}