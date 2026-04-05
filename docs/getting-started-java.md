# Getting Started — Java

This guide explains how to set up and run the Java examples in this repository.

---

## Prerequisites

| Requirement | Minimum Version | Download |
|-------------|----------------|---------|
| JDK | 17 (LTS) | [Adoptium](https://adoptium.net/) or [Oracle](https://www.oracle.com/java/technologies/downloads/) |
| Maven | 3.8+ | [maven.apache.org](https://maven.apache.org/download.cgi) |
| IDE (optional) | — | [IntelliJ IDEA](https://www.jetbrains.com/idea/) or [VS Code + Extension Pack for Java](https://marketplace.visualstudio.com/items?itemName=vscjava.vscode-java-pack) |

Verify your installation:

```bash
java --version
# Expected: openjdk 17.x.x or higher

mvn --version
# Expected: Apache Maven 3.8.x or higher
```

---

## Repository Structure

All Java projects live under `java/DesignPatterns/`. There is a single `pom.xml` at the root that acts as the parent Maven project, with each pattern as a module.

```
java/
└── DesignPatterns/
    ├── pom.xml                          ← root Maven POM
    ├── CreationalDesignPatterns/
    │   ├── AbstractFactoryDesignPattern/
    │   ├── BuilderDesignPattern/
    │   └── ...
    ├── StructuralDesignPatterns/
    └── BehavioralDesignPatterns/
```

---

## Running a Single Example

### Option A — Maven Exec Plugin (recommended)

```bash
# Navigate to any example folder
cd java/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern

# Compile and run
mvn compile exec:java
```

> **Tip:** Each module's `pom.xml` specifies the `mainClass` so you do not need to provide it manually.

### Option B — Compile and run manually

```bash
cd java/DesignPatterns/CreationalDesignPatterns/AbstractFactoryDesignPattern

# Compile
javac -d out src/main/java/**/*.java

# Run (replace with actual main class)
java -cp out com.berkanserbes.Main
```

### Option C — IntelliJ IDEA

1. Open the `java/DesignPatterns/` folder in IntelliJ IDEA.
2. IntelliJ will detect the Maven project automatically and import all modules.
3. Navigate to any `Main.java` file.
4. Click the green **Run** button next to the `main` method.

---

## Building the Entire Project

From the `java/DesignPatterns/` directory:

```bash
mvn clean install
```

To skip tests (if any):

```bash
mvn clean install -DskipTests
```

---

## Running All Examples at Once (Bash/PowerShell)

**Bash:**

```bash
find java/DesignPatterns -name "pom.xml" -not -path "*/DesignPatterns/pom.xml" | while read pom; do
    dir=$(dirname "$pom")
    echo "=== $dir ==="
    (cd "$dir" && mvn -q compile exec:java)
done
```

**PowerShell:**

```powershell
Get-ChildItem -Path java/DesignPatterns -Filter pom.xml -Recurse |
    Where-Object { $_.DirectoryName -ne (Resolve-Path "java/DesignPatterns") } |
    ForEach-Object {
        Write-Host "`n=== $($_.Directory.Name) ===" -ForegroundColor Cyan
        Push-Location $_.DirectoryName
        mvn -q compile exec:java
        Pop-Location
    }
```

---

## Troubleshooting

| Problem | Solution |
|---------|----------|
| `java: command not found` | Install JDK 17+ and ensure `JAVA_HOME` is set |
| `mvn: command not found` | Install Maven and add it to your `PATH` |
| `Cannot find symbol` errors | Make sure you are using JDK 17 or higher (`java --version`) |
| Module not found in IDE | Re-import the Maven project: **Maven → Reload All Maven Projects** |

---

## Back to Main README

[← Back to README](../README.md)
