import { IDocument } from "./IDocument";

/**
 * RealSubject - The actual sensitive document.
 * Contains the real implementation without any access control.
 */
export class SensitiveDocument implements IDocument {
  private _content: string;

  constructor(
    private readonly _name: string,
    content: string
  ) {
    this._content = content;
  }

  read(): void {
    console.log(`[Document] Reading '${this._name}':`);
    console.log(`[Document] Content: ${this._content}`);
  }

  write(content: string): void {
    this._content = content;
    console.log(`[Document] Content updated to: ${this._content}`);
  }

  delete(): void {
    console.log(`[Document] '${this._name}' has been deleted!`);
    this._content = "";
  }
}
