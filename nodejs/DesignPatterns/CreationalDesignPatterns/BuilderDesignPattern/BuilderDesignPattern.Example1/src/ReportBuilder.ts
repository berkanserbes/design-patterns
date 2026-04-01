import { IReportBuilder } from './IReportBuilder';
import { Report } from './Report';

export class ReportBuilder implements IReportBuilder {
  private readonly _report = new Report();

  setTitle(title: string): IReportBuilder {
    this._report.title = title;
    return this;
  }

  setContent(content: string): IReportBuilder {
    this._report.content = content;
    return this;
  }

  setHeader(header: string): IReportBuilder {
    this._report.header = header;
    return this;
  }

  setFooter(footer: string): IReportBuilder {
    this._report.footer = footer;
    return this;
  }

  setFont(font: string): IReportBuilder {
    this._report.font = font;
    return this;
  }

  build(): Report {
    return this._report;
  }
}
