module com.example.mazebank {
    requires javafx.controls;
    requires javafx.fxml;

    requires com.dlsc.formsfx;

    opens com.example.mazebank to javafx.fxml;
    exports com.example.mazebank;
}