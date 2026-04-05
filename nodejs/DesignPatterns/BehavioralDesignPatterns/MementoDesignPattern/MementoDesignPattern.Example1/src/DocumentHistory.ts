import { TextEditor } from './TextEditor';
import { DocumentSnapshot } from './DocumentSnapshot';

export class DocumentHistory {
  private readonly _textEditor: TextEditor;
  private readonly _undoStack: DocumentSnapshot[] = [];
  private readonly _redoStack: DocumentSnapshot[] = [];

  constructor(textEditor: TextEditor) {
    this._textEditor = textEditor;
  }

  backup(snapshotName: string = 'Auto-Save'): void {
    this._undoStack.push(this._textEditor.createSnapshot(snapshotName));
    this._redoStack.length = 0;
  }

  undo(): void {
    if (this._undoStack.length === 0) {
      console.log('No more undo steps available.');
      return;
    }

    this._redoStack.push(this._textEditor.createSnapshot('Before Undo'));
    const previousSnapshot = this._undoStack.pop()!;
    this._textEditor.restoreFromSnapshot(previousSnapshot);
  }

  redo(): void {
    if (this._redoStack.length === 0) {
      console.log('No more redo steps available.');
      return;
    }

    this._undoStack.push(this._textEditor.createSnapshot('Before Redo'));
    const nextSnapshot = this._redoStack.pop()!;
    this._textEditor.restoreFromSnapshot(nextSnapshot);
  }
}
