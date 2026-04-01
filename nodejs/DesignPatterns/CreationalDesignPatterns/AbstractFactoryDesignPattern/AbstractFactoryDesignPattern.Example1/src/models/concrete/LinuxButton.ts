import { Button } from '../../models/abstract/Button';

export class LinuxButton extends Button {
  render(): void { console.log('Rendering Linux Button'); }
  onClick(): void { console.log('Linux Button Clicked'); }
}
