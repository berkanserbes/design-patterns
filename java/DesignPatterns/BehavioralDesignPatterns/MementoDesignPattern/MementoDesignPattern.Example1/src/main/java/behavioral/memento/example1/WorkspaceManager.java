package behavioral.memento.example1;

import java.util.HashMap;
import java.util.Map;

public class WorkspaceManager {
    private final Map<String, DocumentHistory> documents = new HashMap<>();

    public void registerDocument(TextEditor editor) {
        documents.put(editor.createSnapshot("_init").getDocumentId(),
                new DocumentHistory(editor));
    }

    public DocumentHistory getDocumentHistory(String documentId) {
        return documents.get(documentId);
    }
}
