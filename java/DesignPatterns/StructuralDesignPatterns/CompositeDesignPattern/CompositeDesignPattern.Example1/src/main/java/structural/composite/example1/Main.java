package structural.composite.example1;

public class Main {
    public static void main(String[] args) {
        var book = new Product("C# Programming Book", 500);
        var headphones = new Product("Wireless Headphones", 200);
        var phoneCase = new Product("Phone Case", 100);

        var box1 = new Box("Box 1", 200);
        box1.addItem(book);
        box1.addItem(headphones);

        var box2 = new Box("Box 2", 150);
        box2.addItem(phoneCase);
        box2.addItem(box1);

        System.out.println(book.name + " weight: " + book.getWeight() + " gr");
        System.out.println(headphones.name + " weight: " + headphones.getWeight() + " gr");
        System.out.println(phoneCase.name + " weight: " + phoneCase.getWeight() + " gr");
        System.out.println(box1.name + " total weight: " + box1.getWeight() + " gr");
        System.out.println(box2.name + " total weight: " + box2.getWeight() + " gr");
    }
}
