using FlyweightDesignPattern.Example1;

/*
 * Flyweight Design Pattern Example - Forest Rendering System
 * 
 * This example demonstrates how the Flyweight pattern minimizes memory usage
 * when rendering a forest with many trees. Instead of storing duplicate data
 * for each tree, we share common properties (tree type) across multiple instances.
 * 
 * Pattern Components:
 * - ITreeType: Flyweight interface
 * - TreeType: Concrete Flyweight (shared intrinsic state)
 * - TreeTypeFactory: Flyweight Factory (manages shared instances)
 * - Tree: Context (holds extrinsic state + flyweight reference)
 * - SpecialTree: Unshared Concrete Flyweight
 * - Forest: Client
 */

var forest = new Forest();

// Plant many trees of the same types (shares TreeType flyweights)
forest.PlantTree(10, 20, "Oak", "Green", "Rough Bark");
forest.PlantTree(15, 25, "Oak", "Green", "Rough Bark");
forest.PlantTree(50, 30, "Pine", "Dark Green", "Scaly Bark");
forest.PlantTree(100, 50, "Oak", "Green", "Rough Bark");
forest.PlantTree(120, 60, "Birch", "Light Green", "White Bark");
forest.PlantTree(150, 70, "Pine", "Dark Green", "Scaly Bark");

// Plant special trees (unshared flyweights with unique features)
forest.PlantSpecialTree(75, 40, "Ancient Oak", "500 years old, home to owls", 
    "Oak", "Green", "Rough Bark");
forest.PlantSpecialTree(200, 80, "Christmas Pine", "Decorated with lights", 
    "Pine", "Dark Green", "Scaly Bark");

// Render the forest
forest.Draw();

// Show memory savings
forest.DisplayStats();
