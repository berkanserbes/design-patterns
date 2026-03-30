package behavioral.command.example2;

public class LightOffCommand implements ICommand {
    private final Light light;
    public LightOffCommand(Light light) { this.light = light; }

    @Override
    public void execute() { light.turnOff(); }

    @Override
    public void undo() { light.turnOn(); }
}
