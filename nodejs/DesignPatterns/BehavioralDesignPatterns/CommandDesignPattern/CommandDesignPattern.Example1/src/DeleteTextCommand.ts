import { ICommand } from "./ICommand";
import { TextEditor } from "./TextEditor";

/**
 * Concrete Command — deletes N characters from the end of the editor.
 */
export class DeleteTextCommand implements ICommand {
  private _deletedText = "";

  constructor(
    private readonly _editor: TextEditor,
    private readonly _length: number
  ) {}

  execute(): void {
    const deleteLength = Math.min(this._length, this._editor.content.length);
    if (deleteLength > 0) {
      this._deletedText = this._editor.content.slice(-deleteLength);
      this._editor.deleteText(deleteLength);
    }
  }

  unexecute(): void {
    if (this._deletedText) {
      this._editor.appendText(this._deletedText);
    }
  }
}