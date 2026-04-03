// ============================================================================
// COMMAND DESIGN PATTERN - Example 1: Text Editor with Undo/Redo
// ============================================================================
// Command encapsulates a request as an object, enabling undo/redo functionality.
//
// Pattern Structure:
//   - ICommand: Command interface (execute, unexecute)
//   - InsertTextCommand / DeleteTextCommand: Concrete Commands
//   - TextEditor: Receiver
//   - CommandManager: Invoker (maintains undo/redo stacks)
// ============================================================================

import { CommandManager } from "./CommandManager";
import { DeleteTextCommand } from "./DeleteTextCommand";
import { InsertTextCommand } from "./InsertTextCommand";
import { TextEditor } from "./TextEditor";

console.log("=== Command Design Pattern - Text Editor with Undo/Redo ===\n");

const editor = new TextEditor();
const commandManager = new CommandManager();

// Execute commands
commandManager.executeCommand(new InsertTextCommand(editor, "Hello "));
commandManager.executeCommand(new InsertTextCommand(editor, "World!"));
commandManager.executeCommand(new InsertTextCommand(editor, " This is a test."));
editor.displayContent();

// Delete and show result
commandManager.executeCommand(new DeleteTextCommand(editor, 15));
editor.displayContent();

// Undo the delete
commandManager.undo();
editor.displayContent();

// Redo the delete
commandManager.redo();
editor.displayContent();
