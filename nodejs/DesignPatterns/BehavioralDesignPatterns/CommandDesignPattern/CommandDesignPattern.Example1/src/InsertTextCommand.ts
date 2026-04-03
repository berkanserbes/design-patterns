import { ICommand } from "./ICommand";
import { TextEditor } from "./TextEditor";

/**
 * Concrete Command — inserts text into the editor.
 */
export class InsertTextCommand implements ICommand {
  constructor(
    private readonly _editor: TextEditor,
    private readonly _text: string
  ) {}

  execute(): void {
    this._editor.appendText(this._text);
  }

  unexecute(): void {
    this._editor.deleteText(this._text.length);
  }
}