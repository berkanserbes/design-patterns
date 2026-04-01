export class Report {
  title: string = '';
  content: string = '';
  header?: string;
  footer?: string;
  font?: string;

  toString(): string {
    return `Report:\nTitle: ${this.title}\nContent: ${this.content}\nHeader: ${this.header}\nFooter: ${this.footer}\nFont: ${this.font}`;
  }
}
