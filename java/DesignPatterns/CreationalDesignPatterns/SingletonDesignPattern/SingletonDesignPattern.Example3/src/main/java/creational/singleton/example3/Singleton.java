package creational.singleton.example3;

// Thread-Safe Singleton using synchronized block,
// equivalent to C#'s lock(_lock) approach.
public class Singleton {

    private static Singleton instance;
    private static final Object lock = new Object();

    private Singleton() { }

    public static Singleton getInstance() {
        synchronized (lock) {
            if (instance == null) {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
