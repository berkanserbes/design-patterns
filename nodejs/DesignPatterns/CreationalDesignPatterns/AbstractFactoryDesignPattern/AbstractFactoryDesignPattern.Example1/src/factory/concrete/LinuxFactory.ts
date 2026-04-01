import { GUIFactory } from '../abstract/GUIFactory';
import { Button } from '../../models/abstract/Button';
import { Menu } from '../../models/abstract/Menu';
import { Dialog } from '../../models/abstract/Dialog';
import { LinuxButton } from '../../models/concrete/LinuxButton';
import { LinuxMenu } from '../../models/concrete/LinuxMenu';
import { LinuxDialog } from '../../models/concrete/LinuxDialog';

export class LinuxFactory extends GUIFactory {
  createButton(): Button { return new LinuxButton(); }
  createMenu(): Menu { return new LinuxMenu(); }
  createDialog(): Dialog { return new LinuxDialog(); }
}
