import { Dialog } from '../../models/abstract/Dialog';

export class MacDialog extends Dialog {
  render(): void { console.log('Rendering Mac Dialog'); }
  show(): void { console.log('Showing Mac Dialog'); }
  close(): void { console.log('Closing Mac Dialog'); }
}
