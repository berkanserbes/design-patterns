import { Button } from '../../models/abstract/Button';

export class WindowsButton extends Button {
  render(): void { console.log('Rendering Windows Button'); }
  onClick(): void { console.log('Windows Button Clicked'); }
}
