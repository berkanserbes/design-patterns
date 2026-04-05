import { Dialog } from '../../models/abstract/Dialog';

export class WindowsDialog extends Dialog {
  render(): void { console.log('Rendering Windows Dialog'); }
  show(): void { console.log('Showing Windows Dialog'); }
  close(): void { console.log('Closing Windows Dialog'); }
}
