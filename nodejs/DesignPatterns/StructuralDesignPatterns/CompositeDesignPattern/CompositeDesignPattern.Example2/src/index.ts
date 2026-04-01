import { Folder } from './Folder';
import { File } from './File';

const rootFolder = new Folder('root', '/root');
const srcFolder = new Folder('src', '/root/src');

rootFolder.addItem(srcFolder);

const mainFile = new File('main.ts', '/root/src/main.ts', '.ts', 1024);
srcFolder.addItem(mainFile);

const readmeFile = new File('README.md', '/root/README.md', '.md', 2048);
rootFolder.addItem(readmeFile);

console.log(`Total size of root folder: ${rootFolder.getSize()} bytes`);
rootFolder.displayItems();
