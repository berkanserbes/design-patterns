import { Menu } from '../../models/abstract/Menu';

export class MacMenu extends Menu {
  render(): void { console.log('Rendering Mac Menu'); }
  addItem(item: string): void { console.log(`Adding '${item}' to Mac Menu`); }
}
