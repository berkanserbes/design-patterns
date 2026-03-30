package structural.proxy.virtualproxy;

public class ImageProxy implements IImage {
    private final String fileName;
    private final Object lock = new Object();
    private volatile HighResolutionImage realImage;

    public ImageProxy(String fileName) {
        this.fileName = fileName;
        System.out.println("[Proxy] Proxy created for: " + fileName);
    }

    @Override
    public void display() {
        if (realImage == null) {
            synchronized (lock) {
                if (realImage == null) {
                    System.out.println("[Proxy] First access - loading real image...");
                    realImage = new HighResolutionImage(fileName);
                }
            }
        }
        realImage.display();
    }

    public boolean isLoaded() {
        return realImage != null;
    }
}
