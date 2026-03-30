package creational.singleton.example5;

// Initialization-on-demand holder idiom — Java's equivalent of Lazy<T>.
// The inner static class is only loaded when getInstance() is first called,
// providing lazy initialization that is also thread-safe without synchronization.
public class Singleton {

    private Singleton() { }

    private static class SingletonHolder {
        private static final Singleton INSTANCE = new Singleton();
    }

    public static Singleton getInstance() {
        return SingletonHolder.INSTANCE;
    }
}
