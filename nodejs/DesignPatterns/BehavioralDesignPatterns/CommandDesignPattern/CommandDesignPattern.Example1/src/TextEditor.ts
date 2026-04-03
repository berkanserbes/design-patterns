/**
 * Receiver — The text editor that performs the actual operations.
 */
export class TextEditor {
  private _content = "";

  get content(): string {
    return this._content;
  }

  appendText(text: string): void {
    this._content += text;
    console.log(`Text added: '${text}'`);
  }

  deleteText(length: number): void {
    const actual = Math.min(length, this._content.length);
    this._content = this._content.slice(0, this._content.length - actual);
    console.log(`Deleted ${actual} characters`);
  }

  displayContent(): void {
    console.log(`\n=== Editor Content ===`);
    console.log(`'${this._content}'`);
    console.log(`=====================\n`);
  }
}
