package creational.singleton.example4;

// Thread-Safe Singleton using double-checked locking with volatile,
// equivalent to C#'s double-checked locking approach.
public class Singleton {

    private static volatile Singleton instance;
    private static final Object lock = new Object();
    public String value;

    private Singleton() { }

    public static Singleton getInstance(String value) {
        if (instance == null) {
            synchronized (lock) {
                if (instance == null) {
                    instance = new Singleton();
                    instance.value = value;
                }
            }
        }
        return instance;
    }
}
