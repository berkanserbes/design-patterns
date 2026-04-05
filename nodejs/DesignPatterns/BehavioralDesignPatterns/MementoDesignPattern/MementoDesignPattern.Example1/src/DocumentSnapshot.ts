export class DocumentSnapshot {
  readonly content: string;
  readonly fontName: string;
  readonly fontSize: number;
  readonly cursorPosition: number;
  readonly snapshotName: string;
  readonly createdAt: Date;

  constructor(
    content: string,
    fontName: string,
    fontSize: number,
    cursorPosition: number,
    snapshotName: string = 'Auto-Save'
  ) {
    this.content = content;
    this.fontName = fontName;
    this.fontSize = fontSize;
    this.cursorPosition = cursorPosition;
    this.snapshotName = snapshotName;
    this.createdAt = new Date();
  }
}
