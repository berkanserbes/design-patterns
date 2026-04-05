import { Button } from '../../models/abstract/Button';
import { Menu } from '../../models/abstract/Menu';
import { Dialog } from '../../models/abstract/Dialog';

export abstract class GUIFactory {
  abstract createButton(): Button;
  abstract createMenu(): Menu;
  abstract createDialog(): Dialog;
}
