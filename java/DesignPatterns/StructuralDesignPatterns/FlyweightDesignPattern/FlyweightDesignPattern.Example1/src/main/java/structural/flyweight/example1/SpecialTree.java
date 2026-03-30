package structural.flyweight.example1;

public class SpecialTree {
    private final int x;
    private final int y;
    private final String name;
    private final String uniqueFeature;
    private final ITreeType baseType;

    public SpecialTree(int x, int y, String name, String uniqueFeature, ITreeType baseType) {
        this.x = x;
        this.y = y;
        this.name = name;
        this.uniqueFeature = uniqueFeature;
        this.baseType = baseType;
    }

    public void draw() {
        System.out.println("  [SPECIAL] '" + name + "' at (" + x + ", " + y + ") - " + uniqueFeature);
        System.out.println("            Base type: " + baseType.getName() + ", Color: " + baseType.getColor());
    }
}
