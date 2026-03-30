package structural.proxy.protectionproxy;

public interface IDocument {
    void read();
    void write(String content);
    void delete();
}
