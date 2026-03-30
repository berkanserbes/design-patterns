package behavioral.memento.example1;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== Memento Pattern - Text Editor Undo/Redo ===\n");

        TextEditor programEditor = new TextEditor("Program.cs");
        TextEditor readmeEditor = new TextEditor("README.md");

        DocumentHistory programHistory = new DocumentHistory(programEditor);
        DocumentHistory readmeHistory = new DocumentHistory(readmeEditor);

        System.out.println("--- Working on Program.cs ---");
        programHistory.backup("Initial state");
        programEditor.type("using System;");
        programHistory.backup("After first line");
        programEditor.type("\npublic class Program {}");
        programHistory.backup("After class definition");
        programEditor.changeFont("Consolas", 14);
        System.out.println("\nCurrent state:");
        programEditor.displayStatus();

        System.out.println("\n--- Undo x2 on Program.cs ---");
        programHistory.undo();
        programEditor.displayStatus();
        programHistory.undo();
        programEditor.displayStatus();

        System.out.println("\n--- Redo x1 on Program.cs ---");
        programHistory.redo();
        programEditor.displayStatus();

        System.out.println("\n--- Working on README.md ---");
        readmeHistory.backup("Initial state");
        readmeEditor.type("# Design Patterns");
        readmeHistory.backup("After title");
        readmeEditor.type("\nThis project demonstrates design patterns.");
        readmeEditor.changeFont("Times New Roman", 11);
        System.out.println("\nCurrent README state:");
        readmeEditor.displayStatus();

        System.out.println("\n--- Undo README ---");
        readmeHistory.undo();
        readmeEditor.displayStatus();
    }
}
