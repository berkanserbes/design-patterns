package behavioral.command.example2;

public class RemoteControl {
    private static final int SLOTS = 7;
    private final ICommand[] onCommands = new ICommand[SLOTS];
    private final ICommand[] offCommands = new ICommand[SLOTS];
    private ICommand lastCommand = new NoCommand();

    public RemoteControl() {
        for (int i = 0; i < SLOTS; i++) {
            onCommands[i] = new NoCommand();
            offCommands[i] = new NoCommand();
        }
    }

    public void setCommand(int slot, ICommand onCommand, ICommand offCommand) {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    public void onButtonPressed(int slot) {
        onCommands[slot].execute();
        lastCommand = onCommands[slot];
    }

    public void offButtonPressed(int slot) {
        offCommands[slot].execute();
        lastCommand = offCommands[slot];
    }

    public void undoButtonPressed() {
        System.out.println("Geri al:");
        lastCommand.undo();
    }
}
