package creational.prototype.example2;

public class Main {
    public static void main(String[] args) {
        Employee original = new Employee();
        original.name     = "Berkan";
        original.position = "Yazılım Geliştirici";
        original.address  = new Address("Kurtulus Cd.", "Bursa");

        Employee shallowCopy = original.shallowCopy();
        Employee deepCopy    = original.deepCopy();

        shallowCopy.name         = "Ahmet";
        shallowCopy.address.city = "İstanbul";

        deepCopy.name         = "Mehmet";
        deepCopy.address.city = "Ankara";

        System.out.println("ORİJİNAL: " + original.name    + " - " + original.address.city);    // Berkan - İstanbul
        System.out.println("SHALLOW:  " + shallowCopy.name + " - " + shallowCopy.address.city); // Ahmet  - İstanbul
        System.out.println("DEEP:     " + deepCopy.name    + " - " + deepCopy.address.city);    // Mehmet - Ankara
    }
}
