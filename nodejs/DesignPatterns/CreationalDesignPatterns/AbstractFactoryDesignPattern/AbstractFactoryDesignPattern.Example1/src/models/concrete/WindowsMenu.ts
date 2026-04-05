import { Menu } from '../../models/abstract/Menu';

export class WindowsMenu extends Menu {
  render(): void { console.log('Rendering Windows Menu'); }
  addItem(item: string): void { console.log(`Adding '${item}' to Windows Menu`); }
}
