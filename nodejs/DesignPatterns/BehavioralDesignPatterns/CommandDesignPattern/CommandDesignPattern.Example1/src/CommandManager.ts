import { ICommand } from "./ICommand";

/**
 * Invoker — manages command execution and undo/redo history.
 */
export class CommandManager {
  private readonly _undoStack: ICommand[] = [];
  private readonly _redoStack: ICommand[] = [];

  executeCommand(command: ICommand): void {
    command.execute();
    this._undoStack.push(command);
    this._redoStack.length = 0; // clear redo stack on new command
  }

  undo(): void {
    if (this._undoStack.length === 0) {
      console.log("Nothing to undo!");
      return;
    }
    const command = this._undoStack.pop()!;
    command.unexecute();
    this._redoStack.push(command);
    console.log("Undo completed.");
  }

  redo(): void {
    if (this._redoStack.length === 0) {
      console.log("Nothing to redo!");
      return;
    }
    const command = this._redoStack.pop()!;
    command.execute();
    this._undoStack.push(command);
    console.log("Redo completed.");
  }
}
