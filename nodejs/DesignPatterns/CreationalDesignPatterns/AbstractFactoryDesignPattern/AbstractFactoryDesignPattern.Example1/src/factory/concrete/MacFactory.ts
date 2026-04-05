import { GUIFactory } from '../abstract/GUIFactory';
import { Button } from '../../models/abstract/Button';
import { Menu } from '../../models/abstract/Menu';
import { Dialog } from '../../models/abstract/Dialog';
import { MacButton } from '../../models/concrete/MacButton';
import { MacMenu } from '../../models/concrete/MacMenu';
import { MacDialog } from '../../models/concrete/MacDialog';

export class MacFactory extends GUIFactory {
  createButton(): Button { return new MacButton(); }
  createMenu(): Menu { return new MacMenu(); }
  createDialog(): Dialog { return new MacDialog(); }
}
