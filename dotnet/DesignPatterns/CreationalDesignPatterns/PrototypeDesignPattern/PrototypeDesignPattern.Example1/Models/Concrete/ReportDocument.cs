using PrototypeDesignPattern.Example1.Models.Abstract;

namespace PrototypeDesignPattern.Example1.Models.Concrete;

public class ReportDocument : DocumentBase
{
    public ReportHeader Header { get; set; } = new();
    public List<ReportSection> Sections { get; set; } = new();
    public ReportSummary Summary { get; set; } = new();
    public ReportType ReportType { get; set; }

    public ReportDocument()
    {
        Title = "Report Template";
        Content = "Standard Report Template";
        Metadata.Tags.AddRange(new[] { "Report", "Analysis", "Corporate" });
    }

    public override bool ValidateDocument() =>
        !string.IsNullOrEmpty(Header.Title) &&
        !string.IsNullOrEmpty(Header.PreparedBy) &&
        Sections.Count > 0;

    public override string GetDocumentInfo() =>
        $"{base.GetDocumentInfo()}, Report Type: {ReportType}, Sections: {Sections.Count}, Prepared By: {Header.PreparedBy}";
}

public class ReportHeader
{
    public string Title { get; set; } = string.Empty;
    public string PreparedBy { get; set; } = string.Empty;
    public DateTime PreparedDate { get; set; } = DateTime.Now;
    public string Department { get; set; } = string.Empty;
}

public class ReportSection
{
    public string SectionTitle { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public List<string> KeyPoints { get; set; } = new();
    public int Order { get; set; }
}

public class ReportSummary
{
    public string ExecutiveSummary { get; set; } = string.Empty;
    public List<string> Recommendations { get; set; } = new();
    public List<string> Conclusions { get; set; } = new();
}

public enum ReportType
{
    Financial,
    Marketing,
    Technical,
    Management,
    Compliance
}
