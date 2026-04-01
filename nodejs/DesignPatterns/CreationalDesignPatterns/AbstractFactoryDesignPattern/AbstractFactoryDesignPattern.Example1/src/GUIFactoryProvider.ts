import { GUIFactory } from './factory/abstract/GUIFactory';
import { WindowsFactory } from './factory/concrete/WindowsFactory';
import { MacFactory } from './factory/concrete/MacFactory';
import { LinuxFactory } from './factory/concrete/LinuxFactory';

export class GUIFactoryProvider {
  static getFactory(platform: string): GUIFactory {
    switch (platform.toLowerCase()) {
      case 'windows': return new WindowsFactory();
      case 'mac': return new MacFactory();
      case 'linux': return new LinuxFactory();
      default: throw new Error(`Invalid platform: ${platform}`);
    }
  }
}
