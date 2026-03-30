package creational.singleton.example2;

// Eager Initialization: instance is created when the class is loaded,
// equivalent to C#'s static constructor approach.
public class Singleton {

    private static final Singleton instance = new Singleton();

    private Singleton() { }

    public static Singleton getInstance() {
        return instance;
    }
}
