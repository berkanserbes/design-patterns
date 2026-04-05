import { FileSystemItem } from './FileSystemItem';
import { File } from './File';

export class Folder extends FileSystemItem {
  private readonly items: FileSystemItem[] = [];

  constructor(name: string, path: string) { super(name, path); }

  getSize(): number { return this.items.reduce((sum, i) => sum + i.getSize(), 0); }

  addItem(item: FileSystemItem): void { this.items.push(item); }
  removeItem(item: FileSystemItem): void {
    const idx = this.items.indexOf(item);
    if (idx !== -1) this.items.splice(idx, 1);
  }

  displayItems(): void {
    for (const item of this.items) {
      if (item instanceof Folder) {
        console.log(`Folder: ${item.name}, Path: ${item.path}, Created: ${item.createdDate.toISOString()}, Size: ${item.getSize()} bytes`);
        item.displayItems();
      } else if (item instanceof File) {
        console.log(`File: ${item.name}, Path: ${item.path}, Created: ${item.createdDate.toISOString()}, Size: ${item.getSize()} bytes`);
      }
    }
  }
}
