package behavioral.command.example1;

import java.util.ArrayDeque;
import java.util.Deque;

public class CommandManager {
    private final Deque<ICommand> undoStack = new ArrayDeque<>();
    private final Deque<ICommand> redoStack = new ArrayDeque<>();

    public void executeCommand(ICommand command) {
        command.execute();
        undoStack.push(command);
        redoStack.clear();
    }

    public void undo() {
        if (undoStack.isEmpty()) {
            System.out.println("Nothing to undo.");
            return;
        }
        ICommand cmd = undoStack.pop();
        cmd.unexecute();
        redoStack.push(cmd);
    }

    public void redo() {
        if (redoStack.isEmpty()) {
            System.out.println("Nothing to redo.");
            return;
        }
        ICommand cmd = redoStack.pop();
        cmd.execute();
        undoStack.push(cmd);
    }
}
