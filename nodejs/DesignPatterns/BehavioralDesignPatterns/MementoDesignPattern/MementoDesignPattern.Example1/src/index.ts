import { TextEditor } from './TextEditor';
import { WorkspaceManager } from './WorkspaceManager';

const workspaceManager = new WorkspaceManager();

const mainDocument = new TextEditor('Program.cs');
const readmeDocument = new TextEditor('README.md');

workspaceManager.registerDocument(mainDocument);
workspaceManager.registerDocument(readmeDocument);

const mainHistory = workspaceManager.getDocumentHistory(mainDocument.documentId);
const readmeHistory = workspaceManager.getDocumentHistory(readmeDocument.documentId);

console.log('========== Document 1: Program.cs ==========\n');

mainHistory.backup();
mainDocument.type('using System;');

mainHistory.backup();
mainDocument.type('public class Main { Console.WriteLine("Hello World"); }');

mainHistory.backup();
mainDocument.changeFont('Consolas', 14);

mainDocument.displayStatus();

console.log('\n--- Undo (revert font change) ---');
mainHistory.undo();
mainDocument.displayStatus();

console.log('\n--- Undo (revert class block) ---');
mainHistory.undo();
mainDocument.displayStatus();

console.log('\n--- Redo (re-apply class block) ---');
mainHistory.redo();
mainDocument.displayStatus();

console.log('\n========== Document 2: README.md ==========\n');

readmeHistory.backup();
readmeDocument.type('# Memento Design Pattern');

readmeHistory.backup();
readmeDocument.type('\nThis project demonstrates the Memento pattern.');
readmeDocument.displayStatus();

console.log('\n--- Undo on README ---');
readmeHistory.undo();
readmeDocument.displayStatus();
