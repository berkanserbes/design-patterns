import { GUIFactory } from './factory/abstract/GUIFactory';
import { Button } from './models/abstract/Button';
import { Menu } from './models/abstract/Menu';
import { Dialog } from './models/abstract/Dialog';

export class Application {
  private button!: Button;
  private menu!: Menu;
  private dialog!: Dialog;

  constructor(private readonly factory: GUIFactory) {}

  createGUI(): void {
    this.button = this.factory.createButton();
    this.menu = this.factory.createMenu();
    this.dialog = this.factory.createDialog();
  }

  runApplication(): void {
    console.log('=== Starting GUI Application ===');

    this.button.render();
    this.menu.render();
    this.dialog.render();

    console.log('\n=== User Interaction ===');

    this.menu.addItem('File');
    this.menu.addItem('Edit');
    this.menu.addItem('Appearance');

    this.dialog.show();
    this.button.onClick();
    this.dialog.close();
  }
}
