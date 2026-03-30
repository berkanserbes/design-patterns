package behavioral.command.example2;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Command Pattern - Akilli Ev Uzaktan Kumanda ===\n");

        Light oturmaOdasi = new Light("Oturma odasi");
        Light mutfak = new Light("Mutfak");
        Light yatakOdasi = new Light("Yatak odasi");

        RemoteControl remote = new RemoteControl();
        remote.setCommand(0, new LightOnCommand(oturmaOdasi), new LightOffCommand(oturmaOdasi));
        remote.setCommand(1, new LightOnCommand(mutfak), new LightOffCommand(mutfak));
        remote.setCommand(2, new IncreaseBrightnessCommand(oturmaOdasi), new LightOffCommand(oturmaOdasi));

        System.out.println("-- Oturma odasi lambasi ac --");
        remote.onButtonPressed(0);

        System.out.println("-- Mutfak lambasi ac --");
        remote.onButtonPressed(1);

        System.out.println("-- Oturma odasi parlakligini artir --");
        remote.onButtonPressed(2);

        System.out.println("-- Geri al (parlaklik) --");
        remote.undoButtonPressed();

        System.out.println("-- Mutfak lambasi kapat --");
        remote.offButtonPressed(1);

        System.out.println("-- Geri al (mutfak lambasi) --");
        remote.undoButtonPressed();
    }
}
