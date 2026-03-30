package behavioral.command.example2;

public class LightOnCommand implements ICommand {
    private final Light light;
    public LightOnCommand(Light light) { this.light = light; }

    @Override
    public void execute() { light.turnOn(); }

    @Override
    public void undo() { light.turnOff(); }
}
