import { Report } from './Report';

export interface IReportBuilder {
  setTitle(title: string): IReportBuilder;
  setContent(content: string): IReportBuilder;
  setHeader(header: string): IReportBuilder;
  setFooter(footer: string): IReportBuilder;
  setFont(font: string): IReportBuilder;
  build(): Report;
}
