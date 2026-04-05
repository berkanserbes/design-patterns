<div align="center">

# Design Patterns

**A comprehensive, multi-language reference implementation of all 22 classic Gang of Four design patterns.**

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Java](https://img.shields.io/badge/Java-17+-ED8B00?logo=openjdk&logoColor=white)](https://openjdk.org/)
[![Node.js](https://img.shields.io/badge/Node.js-TypeScript-3178C6?logo=typescript&logoColor=white)](https://www.typescriptlang.org/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)
[![Medium](https://img.shields.io/badge/Articles-Medium-black?logo=medium&logoColor=white)](https://medium.com/@berkanserbes)

</div>

---

## Table of Contents

- [What Are Design Patterns?](#what-are-design-patterns)
- [Languages & Tech Stack](#languages--tech-stack)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Pattern Reference](#pattern-reference)
  - [Creational Patterns](#-creational-patterns)
  - [Structural Patterns](#-structural-patterns)
  - [Behavioral Patterns](#-behavioral-patterns)
- [Contributing](#contributing)
- [License](#license)

---

## What Are Design Patterns?

Design patterns are reusable solutions to commonly occurring problems in software design. They are not finished designs that can be directly converted into code. They are templates, best practices, and mental models that help you write more maintainable, flexible, and scalable software.

This repository implements all **22 Gang of Four (GoF)** design patterns across **three languages**, each with **multiple real-world examples** so you can see not just the theory, but how each pattern applies in different contexts.

> 📖 Each pattern comes with a detailed Turkish-language article on [Medium](https://medium.com/@berkanserbes/list/tasarm-desenleri-77a72ce679d4) explaining the concept from first principles.

---

## Languages & Tech Stack

| Language | Runtime | Notes |
|----------|---------|-------|
| **C# / .NET** | .NET 8+ | Console applications |
| **Java** | JDK 17+ | Maven-based projects |
| **TypeScript / Node.js** | Node.js 18+ | `ts-node` for direct execution |

---

## Getting Started

Each language has its own setup guide:

| Guide | Description |
|-------|-------------|
| [.NET / C# Setup Guide](./docs/getting-started-dotnet.md) | How to run .NET examples with the .NET CLI or Visual Studio |
| [Java Setup Guide](./docs/getting-started-java.md) | How to run Java examples with Maven |
| [Node.js / TypeScript Setup Guide](./docs/getting-started-nodejs.md) | How to run Node.js examples with `npm start` |

---

## Project Structure

The repository is organized by language, then by pattern category:

```
design-patterns/
├── dotnet/
│   └── DesignPatterns/
│       ├── DesignPatterns.slnx
│       ├── CreationalDesignPatterns/
│       │   ├── AbstractFactoryDesignPattern/
│       │   ├── BuilderDesignPattern/
│       │   ├── FactoryDesignPattern/
│       │   ├── PrototypeDesignPattern/
│       │   └── SingletonDesignPattern/
│       ├── StructuralDesignPatterns/
│       │   ├── AdapterDesignPattern/
│       │   ├── BridgeDesignPattern/
│       │   ├── CompositeDesignPattern/
│       │   ├── DecoratorDesignPattern/
│       │   ├── FacadeDesignPattern/
│       │   ├── FlyweightDesignPattern/
│       │   └── ProxyDesignPattern/
│       └── BehavioralDesignPatterns/
│           ├── ChainOfResponsibilityDesignPattern/
│           ├── CommandDesignPattern/
│           ├── IteratorDesignPattern/
│           ├── MediatorDesignPattern/
│           ├── MementoDesignPattern/
│           ├── ObserverDesignPattern/
│           ├── StateDesignPattern/
│           ├── StrategyDesignPattern/
│           ├── TemplateMethodDesignPattern/
│           └── VisitorDesignPattern/
│
├── java/
│   └── DesignPatterns/
│       ├── pom.xml
│       ├── CreationalDesignPatterns/   (same structure)
│       ├── StructuralDesignPatterns/   (same structure)
│       └── BehavioralDesignPatterns/   (same structure)
│
└── nodejs/
    └── DesignPatterns/
        ├── CreationalDesignPatterns/   (same structure)
        ├── StructuralDesignPatterns/   (same structure)
        └── BehavioralDesignPatterns/   (same structure)
```

Each pattern folder contains one or more numbered `ExampleN` sub-projects, each demonstrating a distinct real-world use case.

---

## Pattern Reference

### 🏗 Creational Patterns

> Creational patterns deal with object creation mechanisms, aiming to create objects in a manner suitable to the situation.

| Pattern | Intent | Code | Article |
|---------|--------|------|---------|
| **Abstract Factory** | Produce families of related objects without specifying their concrete classes | [C#](./dotnet/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern/) · [Java](./java/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern/) · [TS](./nodejs/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern/) | [Medium](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-abstract-factory-tasar%C4%B1m-deseni-64f56b64fa74) |
| **Builder** | Construct complex objects step by step, separating construction from representation | [C#](./dotnet/DesignPatterns/CreationalDesignPatterns/BuilderDesignPattern/) · [Java](./java/DesignPatterns/CreationalDesignPatterns/BuilderDesignPattern/) · [TS](./nodejs/DesignPatterns/CreationalDesignPatterns/BuilderDesignPattern/) | [Medium](https://medium.com/@berkanserbes/creational-design-pattern-builder-tasar%C4%B1m-deseni-c3ec90fe348d) |
| **Factory Method** | Delegate object creation to subclasses, decoupling client code from concrete types | [C#](./dotnet/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/) · [Java](./java/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/) · [TS](./nodejs/DesignPatterns/CreationalDesignPatterns/FactoryDesignPattern/) | [Medium](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-factory-tasar%C4%B1m-deseni-f5858489167a) |
| **Prototype** | Create new objects by cloning an existing instance | [C#](./dotnet/DesignPatterns/CreationalDesignPatterns/PrototypeDesignPattern/) · [Java](./java/DesignPatterns/CreationalDesignPatterns/PrototypeDesignPattern/) · [TS](./nodejs/DesignPatterns/CreationalDesignPatterns/PrototypeDesignPattern/) | [Medium](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-prototype-tasar%C4%B1m-deseni-929a7276e177) |
| **Singleton** | Ensure a class has only one instance and provide a global access point to it | [C#](./dotnet/DesignPatterns/CreationalDesignPatterns/SingletonDesignPattern/) · [Java](./java/DesignPatterns/CreationalDesignPatterns/SingletonDesignPattern/) · [TS](./nodejs/DesignPatterns/CreationalDesignPatterns/SingletonDesignPattern/) | [Medium](https://medium.com/@berkanserbes/creational-tasar%C4%B1m-desenleri-singleton-tasar%C4%B1m-deseni-e8f8281c18d4) |

---

### 🔩 Structural Patterns

> Structural patterns explain how to assemble objects and classes into larger structures while keeping them flexible and efficient.

| Pattern | Intent | Code | Article |
|---------|--------|------|---------|
| **Adapter** | Allow incompatible interfaces to work together by wrapping one in another | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/AdapterDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-adapter-tasar%C4%B1m-deseni-6d31acb8115f) |
| **Bridge** | Decouple an abstraction from its implementation so both can vary independently | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/BridgeDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/BridgeDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/BridgeDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-bridge-tasar%C4%B1m-deseni-cd31dc479d21) |
| **Composite** | Compose objects into tree structures to represent part-whole hierarchies | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/CompositeDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/CompositeDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/CompositeDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-composite-tasar%C4%B1m-deseni-6bd865d19fb8) |
| **Decorator** | Attach additional responsibilities to an object dynamically without subclassing | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/DecoratorDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-decorator-tasar%C4%B1m-deseni-b053f30d1e2a) |
| **Facade** | Provide a simplified, unified interface to a complex subsystem | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/FacadeDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-facade-tasar%C4%B1m-deseni-eaa0db396446) |
| **Flyweight** | Minimize memory usage by sharing as much data as possible with similar objects | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/FlyweightDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/FlyweightDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/FlyweightDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-flyweight-tasar%C4%B1m-deseni-bf33baed5d46) |
| **Proxy** | Provide a surrogate that controls access to another object, adding cross-cutting concerns | [C#](./dotnet/DesignPatterns/StructuralDesignPatterns/ProxyDesignPattern/) · [Java](./java/DesignPatterns/StructuralDesignPatterns/ProxyDesignPattern/) · [TS](./nodejs/DesignPatterns/StructuralDesignPatterns/ProxyDesignPattern/) | [Medium](https://medium.com/@berkanserbes/structural-tasar%C4%B1m-desenleri-proxy-tasar%C4%B1m-deseni-d5d582afbe86) |

---

### 🔄 Behavioral Patterns

> Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects.

| Pattern | Intent | Code | Article |
|---------|--------|------|---------|
| **Chain of Responsibility** | Pass a request along a chain of handlers; each handler decides to process or forward it | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/ChainOfResponsibilityDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/ChainOfResponsibilityDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/ChainOfResponsibilityDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-chain-of-responsibility-tasar%C4%B1m-deseni-42d606a239d6) |
| **Command** | Encapsulate a request as an object, enabling undo/redo, queuing, and logging | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/CommandDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/CommandDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/CommandDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-command-tasar%C4%B1m-deseni-923646e573fd) |
| **Iterator** | Provide a uniform way to traverse elements of a collection without exposing its internals | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/IteratorDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/IteratorDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/IteratorDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-iterator-tasar%C4%B1m-deseni-bff79724a78e) |
| **Mediator** | Centralize complex communication between objects through a mediator object | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/MediatorDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/MediatorDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/MediatorDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-mediator-tasar%C4%B1m-deseni-9c637162ddf2) |
| **Memento** | Capture and restore an object's internal state without violating encapsulation | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/MementoDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/MementoDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/MementoDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-memento-tasar%C4%B1m-deseni-5d596a8d7678) |
| **Observer** | Define a one-to-many dependency so all dependents are notified when one object changes state | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/ObserverDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/ObserverDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/ObserverDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-observer-tasar%C4%B1m-deseni-3da340a8154e) |
| **State** | Allow an object to alter its behavior when its internal state changes | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/StateDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/StateDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/StateDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-state-tasar%C4%B1m-deseni-4da83dff728a) |
| **Strategy** | Define a family of interchangeable algorithms and select one at runtime | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/StrategyDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/StrategyDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/StrategyDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-strategy-tasar%C4%B1m-deseni-5b28c70728c5) |
| **Template Method** | Define the skeleton of an algorithm, letting subclasses fill in specific steps | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/TemplateMethodDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/TemplateMethodDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/TemplateMethodDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-template-method-tasar%C4%B1m-deseni-e8cb9995b978) |
| **Visitor** | Separate an algorithm from the object structure it operates on, enabling new operations without modifying objects | [C#](./dotnet/DesignPatterns/BehavioralDesignPatterns/VisitorDesignPattern/) · [Java](./java/DesignPatterns/BehavioralDesignPatterns/VisitorDesignPattern/) · [TS](./nodejs/DesignPatterns/BehavioralDesignPatterns/VisitorDesignPattern/) | [Medium](https://medium.com/@berkanserbes/behavioral-tasar%C4%B1m-desenleri-visitor-tasar%C4%B1m-deseni-19c14d492e81) |

---

## Contributing

Contributions are welcome! If you want to add a new example, fix a bug, or improve documentation:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/my-example`)
3. Commit your changes (`git commit -m 'Add Example3 for Visitor pattern'`)
4. Push to the branch (`git push origin feature/my-example`)
5. Open a Pull Request

Please follow the existing folder naming convention (`PatternName.ExampleN`) and make sure your example runs with the standard start command for its language.

---

## License

This project is licensed under the [MIT License](./LICENSE).