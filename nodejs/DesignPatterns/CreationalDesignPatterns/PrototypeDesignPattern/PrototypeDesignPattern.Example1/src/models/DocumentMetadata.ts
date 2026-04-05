export class DocumentMetadata {
  author: string = '';
  version: string = '1.0';
  tags: string[] = [];
  customProperties: Record<string, string> = {};
  pageCount: number = 1;

  toString(): string {
    return `Author: ${this.author}, Version: ${this.version}, Pages: ${this.pageCount}, Tags: [${this.tags.join(', ')}]`;
  }
}
