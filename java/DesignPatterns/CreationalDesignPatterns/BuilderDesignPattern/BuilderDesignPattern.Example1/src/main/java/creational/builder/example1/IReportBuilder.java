package creational.builder.example1;

public interface IReportBuilder {
    IReportBuilder setTitle(String title);
    IReportBuilder setContent(String content);
    IReportBuilder setHeader(String header);
    IReportBuilder setFooter(String footer);
    IReportBuilder setFont(String font);
    Report build();
}
