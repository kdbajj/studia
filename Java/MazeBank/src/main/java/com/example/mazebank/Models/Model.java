package com.example.mazebank.Models;

import com.example.mazebank.Views.Account_Type;
import com.example.mazebank.Views.ViewFactory;

import java.sql.ResultSet;
import java.sql.Struct;
import java.time.LocalDate;

public class Model {
    private static Model model;
    private final ViewFactory viewFactory;
    private final DataBaseDriver dataBaseDriver;
    private Account_Type loginAccountType = Account_Type.CLIENT;

//Client Data Section

    private Model(){
        this.viewFactory = new ViewFactory();
        this.dataBaseDriver = new DataBaseDriver();
        this.clientLoginSuccessFlag = false;
        this.client = new Client("","","",null,null,null);

    }
    private Client client;
    private boolean clientLoginSuccessFlag;
    //Client Data Section

    public static synchronized Model getInstance() {
        if (model == null) {
            model = new Model();
        }

        return model;
    }

    public ViewFactory getViewFactory( ){
        return viewFactory;
    }
public DataBaseDriver getDataBaseDriver() {return dataBaseDriver;}


    public Account_Type getLoginAccountType() {
        return loginAccountType;
    }

    public void setLoginAccountType(Account_Type loginAccountType) {
        this.loginAccountType = loginAccountType;
    }

    /*
    * Client Method
    * */
    public boolean getClientSuccessFlag(){return this.clientLoginSuccessFlag;}
    public void setClientLoginSuccessFlag(boolean flag) {this.clientLoginSuccessFlag = flag;}
    public Client getClient(){
        return client;
    }

    public void evaluateClientCred(String pAddress, String password) {
        CheckingAccount checkingAccount;
        SavingsAccount savingsAccount;

        ResultSet resultSet = dataBaseDriver.getClientData(pAddress, password);

        try{
            if (resultSet.isBeforeFirst()) {
                this.client.firstNameProperty().set(resultSet.getString("FirstName"));
                this.client.lastNameProperty().set(resultSet.getString("LastName"));
                this.client.pAddressProperty().set(resultSet.getString("PayeeAddress"));
                String[] dateParts = resultSet.getString("Date").split("-");
                LocalDate date = LocalDate.of(Integer.parseInt(dateParts[0]), Integer.parseInt(dateParts[1]), Integer.parseInt(dateParts[2]));

                this.client.dateProperty().set(date);
                this.clientLoginSuccessFlag = true;
            }
        } catch (Exception e){
            e.printStackTrace();
        }
    }
}
