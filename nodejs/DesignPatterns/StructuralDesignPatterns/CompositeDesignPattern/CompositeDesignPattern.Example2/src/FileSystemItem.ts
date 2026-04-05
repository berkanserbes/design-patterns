export abstract class FileSystemItem {
  public readonly createdDate: Date;

  constructor(public readonly name: string, public readonly path: string) {
    this.createdDate = new Date();
  }

  abstract getSize(): number;
}
