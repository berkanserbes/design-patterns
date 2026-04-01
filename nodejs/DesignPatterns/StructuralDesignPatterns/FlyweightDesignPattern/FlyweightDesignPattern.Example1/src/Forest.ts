import { Tree } from './Tree';
import { SpecialTree } from './SpecialTree';
import { TreeTypeFactory } from './TreeTypeFactory';

export class Forest {
  private readonly trees: Tree[] = [];
  private readonly specialTrees: SpecialTree[] = [];
  private readonly factory = new TreeTypeFactory();

  plantTree(x: number, y: number, name: string, color: string, texture: string): void {
    const type = this.factory.getTreeType(name, color, texture);
    this.trees.push(new Tree(x, y, type));
  }

  plantSpecialTree(
    x: number, y: number,
    specialName: string, uniqueFeature: string,
    baseName: string, baseColor: string, baseTexture: string,
  ): void {
    const baseType = this.factory.getTreeType(baseName, baseColor, baseTexture);
    this.specialTrees.push(new SpecialTree(x, y, specialName, uniqueFeature, baseType));
  }

  draw(): void {
    console.log('\n=== Forest Rendering ===');
    console.log('Regular Trees:');
    for (const tree of this.trees) {
      tree.draw();
    }
    if (this.specialTrees.length > 0) {
      console.log('\nSpecial Trees:');
      for (const tree of this.specialTrees) {
        tree.draw();
      }
    }
  }

  displayStats(): void {
    console.log('\n=== Memory Statistics ===');
    console.log(`Total trees planted: ${this.trees.length + this.specialTrees.length}`);
    console.log(`  - Regular trees: ${this.trees.length}`);
    console.log(`  - Special trees: ${this.specialTrees.length}`);
    console.log(`Unique TreeType objects in memory: ${this.factory.getTreeTypeCount()}`);
    console.log(`Memory saved by sharing: ${this.trees.length - this.factory.getTreeTypeCount()} TreeType objects`);
  }
}
