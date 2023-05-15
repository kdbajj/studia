import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Stack;

public class SimpleCalculator {
    public static void main(String[] args) {
        JFrame frame = new JFrame("Kalkulator");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(300, 400);

        Container container = frame.getContentPane();
        container.setLayout(new BorderLayout());

        JTextField textField = new JTextField(10);
        textField.setHorizontalAlignment(SwingConstants.RIGHT);//ustawienie wyrównania prawo
        container.add(textField, BorderLayout.NORTH);

        JPanel panel = new JPanel();
        panel.setLayout(new GridLayout(4, 4));

        ActionListener actionListener = new ActionListener() {
            String current = "";//bieżące wyrażenie matematyczne

            @Override
            public void actionPerformed(ActionEvent e) {
                String cmd = e.getActionCommand();
                switch (cmd) {
                    case "=":
                        textField.setText(evaluate(current));
                        current = "";

                        break;
                    case "C":
                        current = "";
                        textField.setText("");
                        break;
                    default:
                        current += cmd;
                        textField.setText(current);
                        break;
                }
            }
        };

        String[] buttons = {
                "7", "8", "9", "/",
                "4", "5", "6", "*",
                "1", "2", "3", "-",
                "0", "C", "=", "+"
        };

        for (String btn : buttons) {
            JButton button = new JButton(btn);
            button.addActionListener(actionListener);
            panel.add(button);
        }

        container.add(panel, BorderLayout.CENTER);
        frame.setVisible(true);
    }

    private static String evaluate(String expression) {
        try {
            if (expression == null || expression.isEmpty()) {
                return "";
            }

            Stack<Double> stack = new Stack<>();
            Stack<Character> operators = new Stack<>();

            for (int i = 0; i < expression.length(); i++) {
                char c = expression.charAt(i);

                if (Character.isDigit(c) || c == '.') {
                    int j = i;
                    while (j < expression.length() && (Character.isDigit(expression.charAt(j)) || expression.charAt(j) == '.')) {
                        j++;
                    }
                    double number = Double.parseDouble(expression.substring(i, j));
                    stack.push(number);
                    i = j - 1;
                } else if (c == '+' || c == '-' || c == '*' || c == '/') {
                    while (!operators.isEmpty() && precedence(c) <= precedence(operators.peek())) {
                        stack.push(applyOperator(operators.pop(), stack.pop(), stack.pop()));
                    }
                    operators.push(c);
                }
            }

            while (!operators.isEmpty()) {
                stack.push(applyOperator(operators.pop(), stack.pop(), stack.pop()));
            }

            return stack.pop().toString();
        } catch (Exception e) {
            return "Błąd";
        }
    }

    private static int precedence(char operator) {
        switch (operator) {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                throw new IllegalArgumentException("Nieprawidłowy operator: " + operator);
        }
    }

    private static double applyOperator(char operator, double b, double a) {
        switch (operator) {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                return a / b;

            default:
                throw new IllegalArgumentException("Nieprawidłowy operator: " + operator);
        }
    }
}