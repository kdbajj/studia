module com.example.przyklad_kodu_gwt {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.przyklad_kodu_gwt to javafx.fxml;
    exports com.example.przyklad_kodu_gwt;
}