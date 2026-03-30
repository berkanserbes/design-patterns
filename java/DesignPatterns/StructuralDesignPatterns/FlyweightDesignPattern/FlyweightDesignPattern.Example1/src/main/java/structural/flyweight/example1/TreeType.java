package structural.flyweight.example1;

public class TreeType implements ITreeType {
    private final String name;
    private final String color;
    private final String texture;

    public TreeType(String name, String color, String texture) {
        this.name = name;
        this.color = color;
        this.texture = texture;
    }

    @Override public String getName() { return name; }
    @Override public String getColor() { return color; }
    @Override public String getTexture() { return texture; }

    @Override
    public void draw(int x, int y) {
        System.out.println("  Drawing '" + name + "' tree at (" + x + ", " + y + ") - Color: " + color + ", Texture: " + texture);
    }
}
