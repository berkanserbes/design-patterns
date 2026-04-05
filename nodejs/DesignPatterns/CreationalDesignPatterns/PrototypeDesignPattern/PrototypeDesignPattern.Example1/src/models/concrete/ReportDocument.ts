import { DocumentBase } from '../abstract/DocumentBase';

export enum ReportType {
  Financial = 'Financial',
  Marketing = 'Marketing',
  Technical = 'Technical',
  Management = 'Management',
  Compliance = 'Compliance',
}

export class ReportHeader {
  title: string = '';
  preparedBy: string = '';
  preparedDate: Date = new Date();
  department: string = '';
}

export class ReportSection {
  sectionTitle: string = '';
  content: string = '';
  keyPoints: string[] = [];
  order: number = 0;
}

export class ReportSummary {
  executiveSummary: string = '';
  recommendations: string[] = [];
  conclusions: string[] = [];
}

export class ReportDocument extends DocumentBase {
  header: ReportHeader = new ReportHeader();
  sections: ReportSection[] = [];
  summary: ReportSummary = new ReportSummary();
  reportType: ReportType = ReportType.Management;

  constructor() {
    super();
    this.title = 'Report Template';
    this.content = 'Standard Report Template';
    this.metadata.tags.push('Report', 'Analysis', 'Corporate');
  }

  validateDocument(): boolean {
    return !!this.header.title && !!this.header.preparedBy && this.sections.length > 0;
  }

  override getDocumentInfo(): string {
    return `${super.getDocumentInfo()}, Report Type: ${this.reportType}, Sections: ${this.sections.length}, Prepared By: ${this.header.preparedBy}`;
  }
}
