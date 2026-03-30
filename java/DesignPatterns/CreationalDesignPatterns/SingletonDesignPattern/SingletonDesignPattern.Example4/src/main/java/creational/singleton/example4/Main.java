package creational.singleton.example4;

public class Main {

    public static void main(String[] args) throws InterruptedException {
        Thread thread1 = new Thread(() -> {
            Singleton instance = Singleton.getInstance("Hello");
            System.out.println("Thread 1 Value: " + instance.value);
            System.out.println("Thread 1: " + System.identityHashCode(instance));
        });

        Thread thread2 = new Thread(() -> {
            Singleton instance = Singleton.getInstance("Hi");
            System.out.println("Thread 2 Value: " + instance.value);
            System.out.println("Thread 2: " + System.identityHashCode(instance));
        });

        thread1.start();
        thread2.start();

        thread1.join();
        thread2.join();
    }
}
