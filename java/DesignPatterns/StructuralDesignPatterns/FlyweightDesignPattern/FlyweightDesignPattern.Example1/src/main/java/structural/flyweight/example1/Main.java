package structural.flyweight.example1;

public class Main {
    public static void main(String[] args) {
        Forest forest = new Forest();

        forest.plantTree(10, 20, "Oak", "Green", "Rough Bark");
        forest.plantTree(15, 25, "Oak", "Green", "Rough Bark");
        forest.plantTree(50, 30, "Pine", "Dark Green", "Scaly Bark");
        forest.plantTree(100, 50, "Oak", "Green", "Rough Bark");
        forest.plantTree(120, 60, "Birch", "Light Green", "White Bark");
        forest.plantTree(150, 70, "Pine", "Dark Green", "Scaly Bark");

        forest.plantSpecialTree(75, 40, "Ancient Oak", "500 years old, home to owls",
            "Oak", "Green", "Rough Bark");
        forest.plantSpecialTree(200, 80, "Christmas Pine", "Decorated with lights",
            "Pine", "Dark Green", "Scaly Bark");

        forest.draw();
        forest.displayStats();
    }
}
