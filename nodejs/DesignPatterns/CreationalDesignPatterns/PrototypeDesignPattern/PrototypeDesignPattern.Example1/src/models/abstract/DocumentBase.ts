import { IDocumentPrototype } from './IDocumentPrototype';
import { DocumentMetadata } from '../DocumentMetadata';

export abstract class DocumentBase implements IDocumentPrototype<DocumentBase> {
  id: string;
  title: string = '';
  content: string = '';
  createdDate: Date;
  lastModified: Date;
  metadata: DocumentMetadata;

  protected constructor() {
    this.id = crypto.randomUUID();
    this.createdDate = new Date();
    this.lastModified = new Date();
    this.metadata = new DocumentMetadata();
  }

  // Shallow clone: reference-type properties share the same reference
  clone(): DocumentBase {
    const cloned = Object.assign(Object.create(Object.getPrototypeOf(this)), this) as DocumentBase;
    cloned.id = crypto.randomUUID();
    cloned.createdDate = new Date();
    cloned.lastModified = new Date();
    return cloned;
  }

  // Deep clone via JSON serialization: produces a fully independent copy
  deepClone(): DocumentBase {
    const cloned = JSON.parse(JSON.stringify(this)) as DocumentBase;
    Object.setPrototypeOf(cloned, Object.getPrototypeOf(this));
    cloned.id = crypto.randomUUID();
    cloned.createdDate = new Date();
    cloned.lastModified = new Date();
    return cloned;
  }

  getDocumentInfo(): string {
    return `ID: ${this.id.slice(0, 8)}..., Title: ${this.title}, Type: ${this.constructor.name}, Created: ${this.createdDate.toISOString().slice(0, 16)}`;
  }

  abstract validateDocument(): boolean;
}
