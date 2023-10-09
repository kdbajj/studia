fun main() {
    val names = listOf("Alice", "Bob", "Charlie")
    val joinedNames = names.joinToString(separator = ", ")
    println(joinedNames) // Wypisze: "Alice, Bob, Charlie"
}

// Powyższy kod demonstruje użycie Kotlin
// do łączenia elementów listy w jeden łańcuch znaków,
// co pokazuje jego czytelność i prostotę w porównaniu z odpowiednikiem w Javie.



//import java.util.Arrays;
//import java.util.List;
//import java.util.stream.Collectors;

//public class JavaExample {
  //  public static void main(String[] args) {
    //    List<String> names = Arrays.asList("Alice", "Bob", "Charlie");
      //  String joinedNames = String.join(", ", names);
        //System.out.println(joinedNames); // Wypisze: "Alice, Bob, Charlie"
    //}
//}