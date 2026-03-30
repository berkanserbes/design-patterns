package creational.prototype.example2;

public interface IPrototype<T> {
    T shallowCopy();
    T deepCopy();
}
