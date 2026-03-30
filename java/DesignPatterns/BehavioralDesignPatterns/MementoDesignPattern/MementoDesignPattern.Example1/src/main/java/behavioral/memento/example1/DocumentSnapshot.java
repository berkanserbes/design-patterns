package behavioral.memento.example1;

import java.time.LocalDateTime;

public class DocumentSnapshot {
    private final String documentId;
    private final String content;
    private final String fontName;
    private final int fontSize;
    private final int cursorPosition;
    private final String snapshotName;
    private final LocalDateTime createdAt;

    public DocumentSnapshot(String documentId, String content, String fontName,
                            int fontSize, int cursorPosition, String snapshotName) {
        this.documentId = documentId;
        this.content = content;
        this.fontName = fontName;
        this.fontSize = fontSize;
        this.cursorPosition = cursorPosition;
        this.snapshotName = snapshotName;
        this.createdAt = LocalDateTime.now();
    }

    public String getDocumentId() { return documentId; }
    public String getContent() { return content; }
    public String getFontName() { return fontName; }
    public int getFontSize() { return fontSize; }
    public int getCursorPosition() { return cursorPosition; }
    public String getSnapshotName() { return snapshotName; }
    public LocalDateTime getCreatedAt() { return createdAt; }
}
