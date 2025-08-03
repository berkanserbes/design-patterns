namespace PrototypeDesignPattern.Example2.Abstracts;

public interface IPrototype<T> where T : class
{
	T ShallowCopy();
	T DeepCopy();
}
