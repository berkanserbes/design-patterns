package creational.singleton.example5;

public class Main {

    public static void main(String[] args) {
        Singleton x = Singleton.getInstance();
        Singleton y = Singleton.getInstance();

        if (x == y) {
            System.out.println("x and y are the same instance.");
        } else {
            System.out.println("x and y are different instances.");
        }

        System.out.println("Hash code of x = " + System.identityHashCode(x));
        System.out.println("Hash code of y = " + System.identityHashCode(y));
    }
}
