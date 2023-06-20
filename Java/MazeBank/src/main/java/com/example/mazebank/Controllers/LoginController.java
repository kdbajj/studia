package com.example.mazebank.Controllers;

import com.example.mazebank.Models.Model;
import com.example.mazebank.Views.Account_Type;
import javafx.collections.FXCollections;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.net.URL;
import java.util.ResourceBundle;

public class LoginController implements Initializable {
    public Label payee_address_lbl;
    public ChoiceBox<Account_Type> acc_selector;
    public TextField payee_address_fld;
    public Label error_lbl;
    public TextField password_fld;
    public Button login_btn;
    public Label password_lbl;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        acc_selector.setItems(FXCollections.observableArrayList(Account_Type.CLIENT, Account_Type.ADMIN));
        acc_selector.setValue(Model.getInstance().getViewFactory().getLoginAccountType());
        acc_selector.valueProperty().addListener(observable -> Model.getInstance().getViewFactory().setLoginAccountType(acc_selector.getValue()));
        login_btn.setOnAction(actionEvent -> onLogin());


    }

    private void onLogin() {
        Stage stage = (Stage) error_lbl.getScene().getWindow();

        if (Model.getInstance().getViewFactory().getLoginAccountType() == Account_Type.CLIENT) {
            Model.getInstance().evaluateClientCred(payee_address_fld.getText(), password_fld.getText());
            if(Model.getInstance().getClientSuccessFlag()) {
                Model.getInstance().getViewFactory().showClientWindow();

                Model.getInstance().getViewFactory().closeStage(stage);
            } else{
                payee_address_fld.setText("");
                password_fld.setText("");
                error_lbl.setText("No such Login or password");
            }
        } else {
            Model.getInstance().getViewFactory().showAdminWindow();
        }
    }
}
