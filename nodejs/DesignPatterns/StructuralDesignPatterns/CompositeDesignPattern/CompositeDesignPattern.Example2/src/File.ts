import { FileSystemItem } from './FileSystemItem';

export class File extends FileSystemItem {
  constructor(
    name: string,
    path: string,
    public readonly extension: string,
    public readonly size: number,
  ) { super(name, path); }

  getSize(): number { return this.size; }
}
