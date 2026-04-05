import { DocumentSnapshot } from './DocumentSnapshot';

export class TextEditor {
  readonly documentId: string;
  private _content: string;
  private _fontName: string;
  private _fontSize: number;
  private _cursorPosition: number;

  get content(): string { return this._content; }
  get fontName(): string { return this._fontName; }
  get fontSize(): number { return this._fontSize; }
  get cursorPosition(): number { return this._cursorPosition; }

  constructor(documentId: string) {
    this.documentId = documentId;
    this._content = '';
    this._fontName = 'Arial';
    this._fontSize = 12;
    this._cursorPosition = 0;
  }

  type(text: string): void {
    this._content += text;
    this._cursorPosition += text.length;
    console.log(`[${this.documentId}] Typed '${text}' --> Content: ${this._content} | Cursor Position: ${this._cursorPosition}`);
  }

  changeFont(fontName: string, fontSize: number): void {
    this._fontName = fontName;
    this._fontSize = fontSize;
    console.log(`[${this.documentId}] Font changed to ${this._fontName} with size ${this._fontSize}`);
  }

  moveCursor(position: number): void {
    this._cursorPosition = position;
    console.log(`[${this.documentId}] Cursor moved to position ${this._cursorPosition}`);
  }

  createSnapshot(name: string = 'Auto-Save'): DocumentSnapshot {
    return new DocumentSnapshot(this._content, this._fontName, this._fontSize, this._cursorPosition, name);
  }

  restoreFromSnapshot(snapshot: DocumentSnapshot): void {
    this._content = snapshot.content;
    this._fontName = snapshot.fontName;
    this._fontSize = snapshot.fontSize;
    this._cursorPosition = snapshot.cursorPosition;
    console.log(`[${this.documentId}] Document restored from snapshot '${snapshot.snapshotName}' (${snapshot.createdAt.toISOString()})`);
  }

  displayStatus(): void {
    console.log(`[${this.documentId}] Content: '${this._content}' | Font: ${this._fontName} (${this._fontSize}pt) | Cursor Position: ${this._cursorPosition}`);
  }
}
