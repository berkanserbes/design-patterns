package behavioral.command.example2;

public class IncreaseBrightnessCommand implements ICommand {
    private final Light light;
    public IncreaseBrightnessCommand(Light light) { this.light = light; }

    @Override
    public void execute() { light.increaseBrightness(); }

    @Override
    public void undo() { light.decreaseBrightness(); }
}
