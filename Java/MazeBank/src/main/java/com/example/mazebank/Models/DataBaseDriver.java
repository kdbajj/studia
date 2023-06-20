package com.example.mazebank.Models;

import java.sql.*;

public class DataBaseDriver {
    private Connection conn;

    public DataBaseDriver() {
        try {
            // Załaduj sterownik JDBC dla SQLite
            Class.forName("org.sqlite.JDBC");

            // Nawiąż połączenie z bazą danych
            this.conn = DriverManager.getConnection("jdbc:sqlite:mazebank.db");
        } catch (SQLException | ClassNotFoundException e) {
            e.printStackTrace();
        }
    }

    public ResultSet getClientData(String pAddress, String password) {
        Statement statement;
        ResultSet resultSet = null;

        try {
            statement = this.conn.createStatement();
            resultSet = statement.executeQuery("SELECT * FROM Clients WHERE PayeeAddress='"+pAddress+"' AND Password='"+password+"'");
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }

        return resultSet;
    }

    /*
     * Client Section
     * */

    /*
     * Admin Section
     * */

    /* Both */
}