package creational.prototype.example1;

import creational.prototype.example1.models.concretes.CVDocument;
import creational.prototype.example1.models.concretes.ProposalDocument;
import creational.prototype.example1.models.concretes.ReportDocument;
import creational.prototype.example1.services.DocumentTemplateManager;

import java.time.LocalDateTime;

public class Main {
    public static void main(String[] args) {
        System.out.println("Prototype Design Pattern - Document Template System");
        System.out.println("=".repeat(60));

        DocumentTemplateManager templateManager = new DocumentTemplateManager();
        templateManager.listAvailableTemplates();

        // --- CV Documents ---
        System.out.println("\n--- CV Documents ---");
        CVDocument cv1 = (CVDocument) templateManager.createDocumentFromTemplate("standard-cv");
        CVDocument cv2 = (CVDocument) templateManager.createDocumentFromTemplateDeep("standard-cv");

        if (cv1 != null && cv2 != null) {
            cv1.personalInfo.fullName = "John Doe";
            cv1.personalInfo.email    = "john.doe@email.com";
            cv1.skills.add("C# Programming");
            CVDocument.WorkExperience exp = new CVDocument.WorkExperience();
            exp.companyName = "Tech Corp";
            exp.position    = "Senior Developer";
            exp.startDate   = LocalDateTime.now().minusYears(2);
            cv1.workExperiences.add(exp);

            cv2.personalInfo.fullName = "Jane Smith";
            cv2.personalInfo.email    = "jane.smith@email.com";
            cv2.skills.clear();
            cv2.skills.addAll(java.util.List.of("Project Management", "Team Leadership", "Agile"));

            System.out.println("CV1: " + cv1.getDocumentInfo() + " | Valid: " + cv1.validateDocument());
            System.out.println("CV2: " + cv2.getDocumentInfo() + " | Valid: " + cv2.validateDocument());
        }

        // --- Business Proposals ---
        System.out.println("\n--- Business Proposals ---");
        ProposalDocument proposal1 = (ProposalDocument) templateManager.createDocumentFromTemplate("standard-proposal");
        ProposalDocument proposal2 = (ProposalDocument) templateManager.createDocumentFromTemplate("standard-proposal");

        if (proposal1 != null && proposal2 != null) {
            proposal1.clientInfo.companyName   = "ABC Corp";
            proposal1.clientInfo.contactPerson = "Alice Johnson";
            ProposalDocument.ProposalItem i1 = new ProposalDocument.ProposalItem();
            i1.description = "Software Development"; i1.quantity = 1; i1.unitPrice = 50000;
            ProposalDocument.ProposalItem i2 = new ProposalDocument.ProposalItem();
            i2.description = "Training Services"; i2.quantity = 2; i2.unitPrice = 5000;
            proposal1.proposalItems.add(i1);
            proposal1.proposalItems.add(i2);
            proposal1.calculateTotal();

            proposal2.clientInfo.companyName   = "XYZ Ltd";
            proposal2.clientInfo.contactPerson = "Bob Wilson";
            proposal2.proposalItems.clear();
            ProposalDocument.ProposalItem i3 = new ProposalDocument.ProposalItem();
            i3.description = "Consulting Services"; i3.quantity = 10; i3.unitPrice = 2000;
            proposal2.proposalItems.add(i3);
            proposal2.calculateTotal();

            System.out.println("Proposal1: " + proposal1.getDocumentInfo() + " | Valid: " + proposal1.validateDocument());
            System.out.println("Proposal2: " + proposal2.getDocumentInfo() + " | Valid: " + proposal2.validateDocument());
        }

        // --- Report Documents ---
        System.out.println("\n--- Report Documents ---");
        ReportDocument report1 = (ReportDocument) templateManager.createDocumentFromTemplateDeep("standard-report");
        if (report1 != null) {
            report1.header.title      = "Q4 2024 Financial Report";
            report1.header.preparedBy = "Finance Team";
            report1.header.department = "Finance";
            report1.reportType        = ReportDocument.ReportType.FINANCIAL;
            ReportDocument.ReportSection s = new ReportDocument.ReportSection();
            s.sectionTitle = "Revenue Analysis";
            s.content      = "Detailed revenue analysis for Q4 2024";
            s.order        = 2;
            report1.sections.add(s);
            report1.summary.executiveSummary = "Strong performance in Q4 2024";
            report1.summary.recommendations.addAll(java.util.List.of("Continue current strategy", "Invest in new markets"));
            System.out.println("Report1: " + report1.getDocumentInfo() + " | Valid: " + report1.validateDocument());
        }

        // --- Shallow vs Deep Clone ---
        System.out.println("\n--- Shallow vs Deep Clone ---");
        ProposalDocument original = (ProposalDocument) templateManager.createDocumentFromTemplate("standard-proposal");
        ProposalDocument shallow  = (ProposalDocument) original.clone();
        ProposalDocument deep     = (ProposalDocument) original.deepClone();

        original.clientInfo.companyName = "Modified Company";
        System.out.println("Original:      " + original.clientInfo.companyName);
        System.out.println("Shallow Clone: " + shallow.clientInfo.companyName);  // shares reference
        System.out.println("Deep Clone:    " + deep.clientInfo.companyName);     // independent copy
    }
}
