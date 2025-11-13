# Design Patterns

This repository contains examples of commonly used design patterns implemented in .NET/C#. Each pattern includes sample code and explanations for better understanding.

## Contents & Medium Articles

| Design Pattern     | Description                                      | GitHub Example                              | Medium Article Link                                                        |
|--------------------|--------------------------------------------------|---------------------------------------------|-----------------------------------------------------------------------------|
| Abstract Factory   | Produces families of related objects via interfaces | [View on GitHub](./dotnet/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern/) | [Link](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-abstract-factory-tasar%C4%B1m-deseni-64f56b64fa74)  |
| Builder            | Constructs complex objects step by step          | [View on GitHub](./dotnet/DesignPatterns/CreationalDesignPatterns/BuilderDesignPattern/) | [Link](https://medium.com/@berkanserbes/creational-design-pattern-builder-tasar%C4%B1m-deseni-c3ec90fe348d) |
| Factory            | Delegates object creation to subclasses          | [View on GitHub](./dotnet/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/) | [Link](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-factory-tasar%C4%B1m-deseni-f5858489167a)          |
| Singleton          | Ensures a class has only one instance            | [View on GitHub](./dotnet/DesignPatterns/CreationalDesignPatterns/SingletonDesignPattern/) | [Link](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-singleton-tasar%C4%B1m-deseni-e8f8281c18d4)        |
| Prototype          | Creates new objects by copying an existing object | [View on GitHub](./dotnet/DesignPatterns/CreationalDesignPatterns/PrototypeDesignPattern/) | [Link](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-prototype-tasar%C4%B1m-deseni-929a7276e177)  |
| Facade             | Provides a simplified interface to a complex subsystem | [View on GitHub](./dotnet/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/) | [Link](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-facade-tasar%C4%B1m-deseni-eaa0db396446) |
| Adapter            | Allows incompatible interfaces to work together   | [View on GitHub](./dotnet/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/) | [Link](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-adapter-tasar%C4%B1m-deseni-6d31acb8115f) |
| Bridge            | Decouples an abstraction from its implementation   | [View on GitHub](./dotnet/DesignPatterns/StructuralDesignPatterns/BridgeDesignPattern/) | [Link](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-bridge-tasar%C4%B1m-deseni-cd31dc479d21) |
| Composite          | Composes objects into tree structures to represent part-whole hierarchies | [View on GitHub](./dotnet/DesignPatterns/StructuralDesignPatterns/CompositeDesignPattern/) | [Link](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-composite-tasar%C4%B1m-deseni-6bd865d19fb8) |
| Decorator          | Adds additional behavior to objects dynamically | [View on GitHub](./dotnet/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/) | [Link](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-decorator-tasar%C4%B1m-deseni-b053f30d1e2a) |
| Strategy           | Defines a family of algorithms and makes them interchangeable | [View on GitHub](./dotnet/DesignPatterns/BehavioralDesignPatterns/StrategyDesignPattern/) | [Link](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-strategy-tasar%C4%B1m-deseni-5b28c70728c5) |
| Template Method    | Defines the skeleton of an algorithm in a method, deferring some steps to subclasses | [View on GitHub](./dotnet/DesignPatterns/BehavioralDesignPatterns/TemplateMethodDesignPattern/) | [Link](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-template-method-tasar%C4%B1m-deseni-e8cb9995b978) |
| Observer           | Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified | [View on GitHub](./dotnet/DesignPatterns/BehavioralDesignPatterns/ObserverDesignPattern/) | [Link](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-observer-tasar%C4%B1m-deseni-3da340a8154e) |
| Chain of Responsibility | Passes a request along a chain of handlers until one of them handles it | [View on GitHub](./dotnet/DesignPatterns/BehavioralDesignPatterns/ChainOfResponsibilityDesignPattern/) | [Link](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-chain-of-responsibility-tasar%C4%B1m-deseni-42d606a239d6) |




## Project Structure

```
dotnet/DesignPatterns/
  ├── CreationalDesignPatterns/
  │   ├── AbstractFactoryDesignPattern/
  │   ├── BuilderDesignPattern/
  │   ├── FactoryDesignPattern/
  │   ├── SingletonDesignPattern/
  │   └── PrototypeDesignPattern/
  ├── StructuralDesignPatterns/
  │   ├── FacadeDesignPattern/
  │   ├── AdapterDesignPattern/
  │   ├── BridgeDesignPattern/
  |   ├── CompositeDesignPattern/
  │   └── DecoratorDesignPattern/
  ├── BehavioralDesignPatterns/
  │   ├── StrategyDesignPattern/
  │   ├── ObserverDesignPattern/
  |   ├── ChainOfResponsibilityDesignPattern/
  │   └── TemplateMethodDesignPattern/
  └── DesignPatterns.sln
```

## Contributing

Feel free to open a pull request or an issue if you want to contribute. All suggestions and feedback are welcome!

## License

MIT License