package structural.flyweight.example1;

import java.util.ArrayList;
import java.util.List;

public class Forest {
    private final List<Tree> trees = new ArrayList<>();
    private final List<SpecialTree> specialTrees = new ArrayList<>();
    private final TreeTypeFactory factory = new TreeTypeFactory();

    public void plantTree(int x, int y, String name, String color, String texture) {
        ITreeType type = factory.getTreeType(name, color, texture);
        trees.add(new Tree(x, y, type));
    }

    public void plantSpecialTree(int x, int y, String specialName, String uniqueFeature,
                                 String baseName, String baseColor, String baseTexture) {
        ITreeType baseType = factory.getTreeType(baseName, baseColor, baseTexture);
        specialTrees.add(new SpecialTree(x, y, specialName, uniqueFeature, baseType));
    }

    public void draw() {
        System.out.println("\n=== Forest Rendering ===");
        System.out.println("Regular Trees:");
        for (Tree tree : trees) tree.draw();
        if (!specialTrees.isEmpty()) {
            System.out.println("\nSpecial Trees:");
            for (SpecialTree tree : specialTrees) tree.draw();
        }
    }

    public void displayStats() {
        System.out.println("\n=== Memory Statistics ===");
        System.out.println("Total trees planted: " + (trees.size() + specialTrees.size()));
        System.out.println("  - Regular trees: " + trees.size());
        System.out.println("  - Special trees: " + specialTrees.size());
        System.out.println("Unique TreeType objects in memory: " + factory.getTreeTypeCount());
        System.out.println("Memory saved by sharing: " + (trees.size() - factory.getTreeTypeCount()) + " TreeType objects");
    }
}
