import { GUIFactory } from '../abstract/GUIFactory';
import { Button } from '../../models/abstract/Button';
import { Menu } from '../../models/abstract/Menu';
import { Dialog } from '../../models/abstract/Dialog';
import { WindowsButton } from '../../models/concrete/WindowsButton';
import { WindowsMenu } from '../../models/concrete/WindowsMenu';
import { WindowsDialog } from '../../models/concrete/WindowsDialog';

export class WindowsFactory extends GUIFactory {
  createButton(): Button { return new WindowsButton(); }
  createMenu(): Menu { return new WindowsMenu(); }
  createDialog(): Dialog { return new WindowsDialog(); }
}
