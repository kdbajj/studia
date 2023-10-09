import com.google.gwt.core.client.EntryPoint;
import com.google.gwt.event.dom.client.ClickEvent;
import com.google.gwt.event.dom.client.ClickHandler;
import com.google.gwt.user.client.ui.Button;
import com.google.gwt.user.client.ui.Label;
import com.google.gwt.user.client.ui.RootPanel;

public class Main implements EntryPoint {
    public void onModuleLoad() {
        Button button = new Button("Click me");
        Label label = new Label();

        button.addClickHandler(new ClickHandler() {
            public void onClick(ClickEvent event) {
                label.setText("Hello, GWT World!");
            }
        });

        RootPanel.get().add(button);
        RootPanel.get().add(label);
    }
}
