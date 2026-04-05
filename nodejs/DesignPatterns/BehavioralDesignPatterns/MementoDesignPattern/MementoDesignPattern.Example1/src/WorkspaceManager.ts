import { TextEditor } from './TextEditor';
import { DocumentHistory } from './DocumentHistory';

export class WorkspaceManager {
  private readonly _documentHistories: Map<string, DocumentHistory> = new Map();

  registerDocument(textEditor: TextEditor): void {
    if (this._documentHistories.has(textEditor.documentId)) {
      throw new Error('Document is already registered.');
    }
    this._documentHistories.set(textEditor.documentId, new DocumentHistory(textEditor));
  }

  getDocumentHistory(documentId: string): DocumentHistory {
    const history = this._documentHistories.get(documentId);
    if (!history) {
      throw new Error('Document not found.');
    }
    return history;
  }
}
