package behavioral.memento.example1;

import java.util.ArrayDeque;
import java.util.Deque;

public class DocumentHistory {
    private final Deque<DocumentSnapshot> undoStack = new ArrayDeque<>();
    private final Deque<DocumentSnapshot> redoStack = new ArrayDeque<>();
    private final TextEditor editor;

    public DocumentHistory(TextEditor editor) { this.editor = editor; }

    public void backup(String name) {
        undoStack.push(editor.createSnapshot(name));
        redoStack.clear();
        System.out.println("  [Backup] Saved snapshot: " + name);
    }

    public boolean undo() {
        if (undoStack.isEmpty()) { System.out.println("  [Undo] Nothing to undo."); return false; }
        DocumentSnapshot current = editor.createSnapshot("temp");
        redoStack.push(current);
        DocumentSnapshot snapshot = undoStack.pop();
        editor.restoreFromSnapshot(snapshot);
        System.out.println("  [Undo] Restored to: " + snapshot.getSnapshotName());
        return true;
    }

    public boolean redo() {
        if (redoStack.isEmpty()) { System.out.println("  [Redo] Nothing to redo."); return false; }
        DocumentSnapshot redoSnapshot = redoStack.pop();
        undoStack.push(editor.createSnapshot("before-redo"));
        editor.restoreFromSnapshot(redoSnapshot);
        System.out.println("  [Redo] Redone to snapshot.");
        return true;
    }
}
