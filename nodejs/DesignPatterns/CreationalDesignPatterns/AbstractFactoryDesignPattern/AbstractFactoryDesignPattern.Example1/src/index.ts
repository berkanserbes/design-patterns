import { GUIFactoryProvider } from './GUIFactoryProvider';
import { Application } from './Application';

console.log('GUI Abstract Factory Example');

const platforms = ['Windows', 'Mac', 'Linux'];

for (const platform of platforms) {
  console.log(`\nPlatform: ${platform}`);
  try {
    const factory = GUIFactoryProvider.getFactory(platform);
    const app = new Application(factory);
    app.createGUI();
    app.runApplication();
  } catch (ex) {
    console.log(`Error: ${(ex as Error).message}`);
  }
}
