import { ITreeType } from './ITreeType';
import { TreeType } from './TreeType';

// Flyweight Factory — manages shared instances
export class TreeTypeFactory {
  private readonly treeTypes = new Map<string, ITreeType>();

  getTreeType(name: string, color: string, texture: string): ITreeType {
    const key = `${name}_${color}_${texture}`;
    if (!this.treeTypes.has(key)) {
      this.treeTypes.set(key, new TreeType(name, color, texture));
    }
    return this.treeTypes.get(key)!;
  }

  getTreeTypeCount(): number {
    return this.treeTypes.size;
  }
}
