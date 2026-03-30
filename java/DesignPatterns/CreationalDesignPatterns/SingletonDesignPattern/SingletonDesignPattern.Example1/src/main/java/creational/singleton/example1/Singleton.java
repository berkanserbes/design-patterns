package creational.singleton.example1;

public class Singleton {

    private static Singleton instance;

    private Singleton() { }

    public static Singleton getOrCreateInstance() {
        if (instance == null) {
            instance = new Singleton();
        }
        return instance;
    }
}
