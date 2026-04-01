import { ReportBuilder } from './ReportBuilder';

const builder = new ReportBuilder();

const report = builder
  .setHeader('header')
  .setTitle('title')
  .setContent('content')
  .setFooter('footer')
  .setFont('font')
  .build();

console.log(report.toString());
