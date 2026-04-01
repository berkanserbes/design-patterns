import { Menu } from '../../models/abstract/Menu';

export class LinuxMenu extends Menu {
  render(): void { console.log('Rendering Linux Menu'); }
  addItem(item: string): void { console.log(`Adding '${item}' to Linux Menu`); }
}
