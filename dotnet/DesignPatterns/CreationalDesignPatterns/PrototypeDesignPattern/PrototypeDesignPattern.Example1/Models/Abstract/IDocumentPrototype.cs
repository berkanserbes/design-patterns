namespace PrototypeDesignPattern.Example1.Models.Abstract;

public interface IDocumentPrototype<T>
{
    T Clone();
    T DeepClone();
    string GetDocumentInfo();
}