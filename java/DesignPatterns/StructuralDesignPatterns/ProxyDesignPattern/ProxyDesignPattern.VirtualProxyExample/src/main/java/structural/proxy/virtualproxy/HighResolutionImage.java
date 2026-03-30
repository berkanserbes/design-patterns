package structural.proxy.virtualproxy;

public class HighResolutionImage implements IImage {
    private final String fileName;

    public HighResolutionImage(String fileName) {
        this.fileName = fileName;
        loadImageFromDisk();
    }

    private void loadImageFromDisk() {
        System.out.println("[RealImage] Loading image: " + fileName);
        System.out.println("[RealImage] Connecting to storage...");
        try { Thread.sleep(1000); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        System.out.println("[RealImage] Downloading image data...");
        try { Thread.sleep(1500); } catch (InterruptedException e) { Thread.currentThread().interrupt(); }
        System.out.println("[RealImage] Image '" + fileName + "' loaded successfully!");
    }

    @Override
    public void display() {
        System.out.println("[RealImage] Displaying: " + fileName);
    }
}
