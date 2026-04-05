import { ICommand } from "./ICommand";
import { NoCommand } from "./Commands";

const SLOTS = 7;

/**
 * Invoker — the remote control with on/off button pairs and single-step undo.
 */
export class RemoteControl {
  private readonly _onCommands: ICommand[];
  private readonly _offCommands: ICommand[];
  private _lastCommand: ICommand;

  constructor() {
    const noCommand = new NoCommand();
    this._onCommands  = Array.from({ length: SLOTS }, () => noCommand);
    this._offCommands = Array.from({ length: SLOTS }, () => noCommand);
    this._lastCommand = noCommand;
  }

  setCommand(slot: number, onCommand: ICommand, offCommand: ICommand): void {
    this._onCommands[slot]  = onCommand;
    this._offCommands[slot] = offCommand;
  }

  onButtonPressed(slot: number): void {
    this._onCommands[slot].execute();
    this._lastCommand = this._onCommands[slot];
  }

  offButtonPressed(slot: number): void {
    this._offCommands[slot].execute();
    this._lastCommand = this._offCommands[slot];
  }

  undoButtonPressed(): void {
    this._lastCommand.undo();
  }

  printCommands(): void {
    console.log("\n----- Remote Control -----");
    for (let i = 0; i < SLOTS; i++) {
      console.log(`[slot ${i}] ${this._onCommands[i].constructor.name} | ${this._offCommands[i].constructor.name}`);
    }
  }
}
