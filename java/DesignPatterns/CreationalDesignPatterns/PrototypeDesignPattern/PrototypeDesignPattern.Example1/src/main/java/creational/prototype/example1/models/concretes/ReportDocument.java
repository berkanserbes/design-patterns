package creational.prototype.example1.models.concretes;

import creational.prototype.example1.models.abstracts.DocumentBase;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

public class ReportDocument extends DocumentBase {
    public ReportHeader      header     = new ReportHeader();
    public List<ReportSection> sections = new ArrayList<>();
    public ReportSummary     summary    = new ReportSummary();
    public ReportType        reportType = ReportType.MANAGEMENT;

    public ReportDocument() {
        title   = "Report Template";
        content = "Standard Report Template";
        metadata.tags.addAll(List.of("Report", "Analysis", "Corporate"));
    }

    @Override
    public boolean validateDocument() {
        return header.title != null && !header.title.isBlank()
            && header.preparedBy != null && !header.preparedBy.isBlank()
            && !sections.isEmpty();
    }

    @Override
    public String getDocumentInfo() {
        return super.getDocumentInfo() +
               ", Report Type: " + reportType +
               ", Sections: " + sections.size() +
               ", Prepared By: " + header.preparedBy;
    }

    public static class ReportHeader {
        public String        title        = "";
        public String        preparedBy   = "";
        public LocalDateTime preparedDate = LocalDateTime.now();
        public String        department   = "";
    }

    public static class ReportSection {
        public String       sectionTitle = "";
        public String       content      = "";
        public List<String> keyPoints    = new ArrayList<>();
        public int          order;
    }

    public static class ReportSummary {
        public String       executiveSummary  = "";
        public List<String> recommendations   = new ArrayList<>();
        public List<String> conclusions       = new ArrayList<>();
    }

    public enum ReportType {
        FINANCIAL, MARKETING, TECHNICAL, MANAGEMENT, COMPLIANCE
    }
}
