package creational.builder.example1;

public class ReportBuilder implements IReportBuilder {
    private final Report report = new Report();

    public IReportBuilder setTitle(String title)     { report.title   = title;   return this; }
    public IReportBuilder setContent(String content) { report.content = content; return this; }
    public IReportBuilder setHeader(String header)   { report.header  = header;  return this; }
    public IReportBuilder setFooter(String footer)   { report.footer  = footer;  return this; }
    public IReportBuilder setFont(String font)       { report.font    = font;    return this; }
    public Report build() { return report; }
}
