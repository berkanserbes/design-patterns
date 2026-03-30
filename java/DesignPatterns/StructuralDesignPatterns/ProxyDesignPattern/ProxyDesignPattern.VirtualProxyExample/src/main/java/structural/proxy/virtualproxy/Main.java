package structural.proxy.virtualproxy;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== VIRTUAL PROXY PATTERN DEMO ===\n");
        System.out.println("--- Creating image proxies (instant) ---\n");

        IImage image1 = new ImageProxy("photo1.png");
        IImage image2 = new ImageProxy("photo2.png");
        IImage image3 = new ImageProxy("photo3.png");

        System.out.println("\n--- All proxies created. No images loaded yet! ---\n");

        System.out.println("--- Displaying image 2 (triggers loading) ---\n");
        image2.display();

        System.out.println("\n--- Displaying image 2 again (already loaded) ---\n");
        image2.display();

        System.out.println("\n--- Checking which images are loaded ---\n");
        System.out.println("Image 1: " + (((ImageProxy) image1).isLoaded() ? "LOADED" : "NOT LOADED"));
        System.out.println("Image 2: " + (((ImageProxy) image2).isLoaded() ? "LOADED" : "NOT LOADED"));
        System.out.println("Image 3: " + (((ImageProxy) image3).isLoaded() ? "LOADED" : "NOT LOADED"));

        System.out.println("\n=== SUMMARY ===");
        System.out.println("Only image 2 was loaded because only it was displayed.");
        System.out.println("Images 1 and 3 remain unloaded - saving resources!");
    }
}
