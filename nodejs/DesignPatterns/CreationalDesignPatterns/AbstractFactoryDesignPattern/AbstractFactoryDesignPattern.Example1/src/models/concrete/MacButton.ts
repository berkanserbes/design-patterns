import { Button } from '../../models/abstract/Button';

export class MacButton extends Button {
  render(): void { console.log('Rendering Mac Button'); }
  onClick(): void { console.log('Mac Button Clicked'); }
}
