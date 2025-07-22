namespace BuilderDesignPattern.Example1;

public class ReportBuilder : IReportBuilder
{
    private readonly Report _report = new();

    public IReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public IReportBuilder SetContent(string content)
    {
        _report.Content = content;
        return this;
    }

    public IReportBuilder SetHeader(string header)
    {
        _report.Header = header;
        return this;
    }

    public IReportBuilder SetFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public IReportBuilder SetFont(string font)
    {
        _report.Font = font;
        return this;
    }

    public Report Build()
    {
        return _report;
    }
}