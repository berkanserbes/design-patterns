namespace BuilderDesignPattern.Example1;

public interface IReportBuilder
{
    IReportBuilder SetTitle(string title);
    IReportBuilder SetContent(string content);
    IReportBuilder SetHeader(string header);
    IReportBuilder SetFooter(string footer);
    IReportBuilder SetFont(string font);
    Report Build();
}

