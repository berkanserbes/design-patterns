import { Dialog } from '../../models/abstract/Dialog';

export class LinuxDialog extends Dialog {
  render(): void { console.log('Rendering Linux Dialog'); }
  show(): void { console.log('Showing Linux Dialog'); }
  close(): void { console.log('Closing Linux Dialog'); }
}
