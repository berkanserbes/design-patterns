package creational.prototype.example1.models.abstracts;

public interface IDocumentPrototype<T> {
    T clone();
    T deepClone();
    String getDocumentInfo();
}
