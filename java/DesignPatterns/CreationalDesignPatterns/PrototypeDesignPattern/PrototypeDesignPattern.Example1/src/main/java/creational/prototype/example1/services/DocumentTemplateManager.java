package creational.prototype.example1.services;

import creational.prototype.example1.models.abstracts.DocumentBase;
import creational.prototype.example1.models.concretes.CVDocument;
import creational.prototype.example1.models.concretes.ProposalDocument;
import creational.prototype.example1.models.concretes.ReportDocument;

import java.time.LocalDateTime;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class DocumentTemplateManager {
    private final Map<String, DocumentBase> templates = new HashMap<>();

    public DocumentTemplateManager() {
        initializeTemplates();
    }

    private void initializeTemplates() {
        CVDocument cvTemplate = new CVDocument();
        cvTemplate.title                     = "Standard CV Template";
        cvTemplate.personalInfo.fullName     = "[Your Name]";
        cvTemplate.personalInfo.email        = "[your.email@example.com]";
        cvTemplate.personalInfo.phone        = "[Your Phone]";
        cvTemplate.personalInfo.address      = "[Your Address]";
        cvTemplate.skills.addAll(List.of("[Skill 1]", "[Skill 2]", "[Skill 3]"));
        CVDocument.Education edu = new CVDocument.Education();
        edu.institution   = "[University Name]";
        edu.degree        = "[Degree]";
        edu.fieldOfStudy  = "[Field of Study]";
        edu.graduationYear = LocalDateTime.now().getYear();
        cvTemplate.education.add(edu);

        ProposalDocument proposalTemplate = new ProposalDocument();
        proposalTemplate.title                      = "Standard Business Proposal";
        proposalTemplate.clientInfo.companyName     = "[Client Company]";
        proposalTemplate.clientInfo.contactPerson   = "[Contact Person]";
        proposalTemplate.clientInfo.email           = "[client@example.com]";
        proposalTemplate.terms                      = "Standard terms and conditions apply.";
        ProposalDocument.ProposalItem item = new ProposalDocument.ProposalItem();
        item.description = "[Service/Product Description]";
        item.quantity    = 1;
        proposalTemplate.proposalItems.add(item);

        ReportDocument reportTemplate = new ReportDocument();
        reportTemplate.title               = "Standard Report Template";
        reportTemplate.reportType          = ReportDocument.ReportType.MANAGEMENT;
        reportTemplate.header.title        = "[Report Title]";
        reportTemplate.header.preparedBy   = "[Your Name]";
        reportTemplate.header.department   = "[Department]";
        ReportDocument.ReportSection section = new ReportDocument.ReportSection();
        section.sectionTitle = "Executive Summary";
        section.content      = "[Executive summary content]";
        section.order        = 1;
        reportTemplate.sections.add(section);

        registerTemplate("standard-cv",       cvTemplate);
        registerTemplate("standard-proposal", proposalTemplate);
        registerTemplate("standard-report",   reportTemplate);
    }

    public void registerTemplate(String templateId, DocumentBase template) {
        templates.put(templateId, template);
        System.out.println("Template registered: " + templateId);
    }

    public DocumentBase createDocumentFromTemplate(String templateId) {
        DocumentBase template = templates.get(templateId);
        if (template == null) {
            System.out.println("Template not found: " + templateId);
            return null;
        }
        return template.clone();
    }

    public DocumentBase createDocumentFromTemplateDeep(String templateId) {
        DocumentBase template = templates.get(templateId);
        if (template == null) {
            System.out.println("Template not found: " + templateId);
            return null;
        }
        return template.deepClone();
    }

    public void listAvailableTemplates() {
        System.out.println("\nAvailable Templates:");
        System.out.println("=".repeat(50));
        templates.forEach((k, v) -> System.out.println("ID: " + k + " - " + v.getDocumentInfo()));
    }
}
