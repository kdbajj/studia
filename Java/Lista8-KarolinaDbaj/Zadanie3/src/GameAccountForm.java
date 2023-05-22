import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class GameAccountForm extends JFrame {

    private JTextField nickTextField;
    private JTextField firstNameTextField;
    private JTextField lastNameTextField;
    private JTextField emailTextField;
    private JRadioButton maleRadioButton;
    private JRadioButton femaleRadioButton;
    private JButton submitButton;

    public GameAccountForm() {
        setTitle("Formularz tworzenia konta w grze");
        setSize(400, 300);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new GridLayout(6, 2));

        nickTextField = new JTextField();
        firstNameTextField = new JTextField();
        lastNameTextField = new JTextField();
        emailTextField = new JTextField();

        maleRadioButton = new JRadioButton("Mężczyzna");
        femaleRadioButton = new JRadioButton("Kobieta");
        ButtonGroup genderGroup = new ButtonGroup();
        genderGroup.add(maleRadioButton);
        genderGroup.add(femaleRadioButton);

        submitButton = new JButton("Zatwierdź");

        add(new JLabel("Nick:"));
        add(nickTextField);
        add(new JLabel("Imię:"));
        add(firstNameTextField);
        add(new JLabel("Nazwisko:"));
        add(lastNameTextField);
        add(new JLabel("E-mail:"));
        add(emailTextField);
        add(maleRadioButton);
        add(femaleRadioButton);
        add(submitButton);

        submitButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                try {
                    validateForm();
                    JOptionPane.showMessageDialog(null, "Formularz został zatwierdzony!");
                } catch (Exception ex) {
                    JOptionPane.showMessageDialog(null, ex.getMessage(), "Błąd", JOptionPane.ERROR_MESSAGE);
                }
            }
        });

        setVisible(true);
    }

    private void validateForm() throws Exception {
        String nick = nickTextField.getText();
        String firstName = firstNameTextField.getText();
        String lastName = lastNameTextField.getText();
        String email = emailTextField.getText();

        if (!nick.matches("^\\w{6,}\\d+.*$")) {
            throw new Exception("Nick musi mieć co najmniej 6 znaków i zawierać przynajmniej jedną cyfrę.");
        }

        if (!firstName.matches("^[A-Z][a-zA-Z]*$")) {
            throw new Exception("Imię musi zaczynać się z dużej litery i zawierać tylko litery.");
        }

        if (!lastName.matches("^[A-Z][a-zA-Z]*$")) {
            throw new Exception("Nazwisko musi zaczynać się z dużej litery i zawierać tylko litery.");
        }

        if (!email.matches("^[\\w.-]+@gra\\.pl$")) {
            throw new Exception("E-mail musi kończyć się na @gra.pl.");
        }

        if (maleRadioButton.isSelected()) {
            if (!firstName.matches(".*(ek|usz)$")) {
                throw new Exception("Imię męskie musi kończyć się na 'ek' lub 'usz'.");
            }
        } else if (femaleRadioButton.isSelected()) {
            if (!firstName.matches(".*(ta|na)$")) {
                throw new Exception("Imię żeńskie musi kończyć się na 'ta' lub 'na'.");
            }
        } else {
            throw new Exception("Musisz wybrać płeć.");
        }
    }

    public static void main(String[] args) {
        new GameAccountForm();
    }
}