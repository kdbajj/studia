import javax.swing.*;
import java.awt.*;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

public class PersonalDataForm {

    public static void main(String[] args) {
        JFrame frame = new JFrame("Formularz danych osobowych");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 300);

        Container container = frame.getContentPane();
        container.setLayout(new GridLayout(5, 1));

        JTextField firstNameTextField = createHintTextField("Imię");
        container.add(firstNameTextField);

        JTextField lastNameTextField = createHintTextField("Nazwisko");
        container.add(lastNameTextField);



        JTextField peselTextField = createHintTextField("Numer PESEL");
        peselTextField.setToolTipText("Podaj 11-cyfrowy numer PESEL");
        container.add(peselTextField);

        JButton submitButton = new JButton("Zatwierdź");
        submitButton.addActionListener(e -> {
            String firstName = firstNameTextField.getText();
            String lastName = lastNameTextField.getText();
            String peselNumber = peselTextField.getText();

            if (!firstName.isEmpty() && !lastName.isEmpty() && !peselNumber.isEmpty()) {
                JOptionPane.showMessageDialog(frame, "Imię: " + firstName + "\nNazwisko: " + lastName + "\nNumer PESEL: " + peselNumber);
            } else {
                JOptionPane.showMessageDialog(frame, "Wypełnij wszystkie pola!", "Błąd", JOptionPane.ERROR_MESSAGE);
            }
        });
        container.add(submitButton);

        frame.setVisible(true);
    }

    private static JTextField createHintTextField(String hint) {
        JTextField textField = new JTextField(hint);
        textField.setForeground(Color.GRAY);
        textField.addFocusListener(new FocusAdapter() {
            @Override
            public void focusGained(FocusEvent e) {
                if (textField.getText().equals(hint)) {
                    textField.setText("");
                    textField.setForeground(Color.BLACK);
                }
            }

            @Override
            public void focusLost(FocusEvent e) {
                if (textField.getText().isEmpty()) {
                    textField.setForeground(Color.GRAY);
                    textField.setText(hint);
                }
            }
        });

        textField.addMouseListener(new MouseAdapter() {
            @Override
            public void mouseEntered(MouseEvent e) {
                textField.setToolTipText(textField.getToolTipText());
            }
        });

        return textField;
    }
}