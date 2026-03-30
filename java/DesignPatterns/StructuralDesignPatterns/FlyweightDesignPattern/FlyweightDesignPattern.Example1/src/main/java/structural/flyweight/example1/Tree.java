package structural.flyweight.example1;

public class Tree {
    private final int x;
    private final int y;
    private final ITreeType type;

    public Tree(int x, int y, ITreeType type) {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public void draw() { type.draw(x, y); }
}
