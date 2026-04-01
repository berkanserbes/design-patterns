import { DocumentBase } from '../models/abstract/DocumentBase';
import { CVDocument, Education, PersonalInfo } from '../models/concrete/CVDocument';
import { ProposalDocument, ClientInfo, ProposalItem } from '../models/concrete/ProposalDocument';
import { ReportDocument, ReportType, ReportHeader, ReportSection } from '../models/concrete/ReportDocument';

// Prototype Registry: stores pre-configured document templates and produces clones on demand
export class DocumentTemplateManager {
  private readonly _templates = new Map<string, DocumentBase>();

  constructor() {
    this.initializeTemplates();
  }

  private initializeTemplates(): void {
    const cvTemplate = new CVDocument();
    cvTemplate.title = 'Standard CV Template';
    cvTemplate.personalInfo.fullName = '[Your Name]';
    cvTemplate.personalInfo.email = '[your.email@example.com]';
    cvTemplate.personalInfo.phone = '[Your Phone]';
    cvTemplate.personalInfo.address = '[Your Address]';
    cvTemplate.skills.push('[Skill 1]', '[Skill 2]', '[Skill 3]');
    cvTemplate.education.push({
      institution: '[University Name]',
      degree: '[Degree]',
      fieldOfStudy: '[Field of Study]',
      graduationYear: new Date().getFullYear(),
    });

    const proposalTemplate = new ProposalDocument();
    proposalTemplate.title = 'Standard Business Proposal';
    proposalTemplate.clientInfo.companyName = '[Client Company]';
    proposalTemplate.clientInfo.contactPerson = '[Contact Person]';
    proposalTemplate.clientInfo.email = '[client@example.com]';
    proposalTemplate.terms = 'Standard terms and conditions apply.';
    proposalTemplate.validityDays = 30;
    proposalTemplate.proposalItems.push({ description: '[Service/Product Description]', quantity: 1, unitPrice: 0, notes: '' });

    const reportTemplate = new ReportDocument();
    reportTemplate.title = 'Standard Report Template';
    reportTemplate.reportType = ReportType.Management;
    reportTemplate.header.title = '[Report Title]';
    reportTemplate.header.preparedBy = '[Your Name]';
    reportTemplate.header.department = '[Department]';
    reportTemplate.sections.push({ sectionTitle: 'Executive Summary', content: '[Executive summary content]', keyPoints: [], order: 1 });

    this.registerTemplate('standard-cv', cvTemplate);
    this.registerTemplate('standard-proposal', proposalTemplate);
    this.registerTemplate('standard-report', reportTemplate);
  }

  registerTemplate(templateId: string, template: DocumentBase): void {
    this._templates.set(templateId, template);
    console.log(`Template registered: ${templateId}`);
  }

  createDocumentFromTemplate(templateId: string): DocumentBase | null {
    const template = this._templates.get(templateId);
    if (!template) { console.log(`Template not found: ${templateId}`); return null; }
    return template.clone();
  }

  createDocumentFromTemplateDeep(templateId: string): DocumentBase | null {
    const template = this._templates.get(templateId);
    if (!template) { console.log(`Template not found: ${templateId}`); return null; }
    return template.deepClone();
  }

  listAvailableTemplates(): void {
    console.log('\nAvailable Templates:');
    console.log('='.repeat(50));
    for (const [key, template] of this._templates)
      console.log(`ID: ${key} - ${template.getDocumentInfo()}`);
  }

  getTemplateCount(): number { return this._templates.size; }
}
