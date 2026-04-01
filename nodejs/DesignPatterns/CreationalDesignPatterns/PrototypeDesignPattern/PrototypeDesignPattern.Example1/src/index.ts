import { DocumentTemplateManager } from './services/DocumentTemplateManager';
import { CVDocument, WorkExperience } from './models/concrete/CVDocument';
import { ProposalDocument, ProposalItem } from './models/concrete/ProposalDocument';
import { ReportDocument, ReportType, ReportSection } from './models/concrete/ReportDocument';

console.log('Prototype Design Pattern - Document Template System');
console.log('='.repeat(60));

const templateManager = new DocumentTemplateManager();
templateManager.listAvailableTemplates();

// --- CV Documents ---
console.log('\n--- CV Documents ---');
const cv1 = templateManager.createDocumentFromTemplate('standard-cv') as CVDocument;
const cv2 = templateManager.createDocumentFromTemplateDeep('standard-cv') as CVDocument;

if (cv1 && cv2) {
  cv1.personalInfo.fullName = 'John Doe';
  cv1.personalInfo.email = 'john.doe@email.com';
  cv1.skills.push('TypeScript Programming');
  cv1.workExperiences.push({ companyName: 'Tech Corp', position: 'Senior Developer', startDate: new Date(), description: '' });

  cv2.personalInfo.fullName = 'Jane Smith';
  cv2.personalInfo.email = 'jane.smith@email.com';
  cv2.skills = ['Project Management', 'Team Leadership', 'Agile'];

  console.log(`CV1: ${cv1.getDocumentInfo()} | Valid: ${cv1.validateDocument()}`);
  console.log(`CV2: ${cv2.getDocumentInfo()} | Valid: ${cv2.validateDocument()}`);
}

// --- Business Proposals ---
console.log('\n--- Business Proposals ---');
const proposal1 = templateManager.createDocumentFromTemplate('standard-proposal') as ProposalDocument;
const proposal2 = templateManager.createDocumentFromTemplate('standard-proposal') as ProposalDocument;

if (proposal1 && proposal2) {
  proposal1.clientInfo.companyName = 'ABC Corp';
  proposal1.clientInfo.contactPerson = 'Alice Johnson';
  proposal1.proposalItems.push({ description: 'Software Development', quantity: 1, unitPrice: 50000, notes: '' });
  proposal1.proposalItems.push({ description: 'Training Services', quantity: 2, unitPrice: 5000, notes: '' });
  proposal1.calculateTotal();

  proposal2.clientInfo.companyName = 'XYZ Ltd';
  proposal2.clientInfo.contactPerson = 'Bob Wilson';
  proposal2.proposalItems = [{ description: 'Consulting Services', quantity: 10, unitPrice: 2000, notes: '' }];
  proposal2.calculateTotal();

  console.log(`Proposal1: ${proposal1.getDocumentInfo()} | Valid: ${proposal1.validateDocument()}`);
  console.log(`Proposal2: ${proposal2.getDocumentInfo()} | Valid: ${proposal2.validateDocument()}`);
}

// --- Report Documents ---
console.log('\n--- Report Documents ---');
const report1 = templateManager.createDocumentFromTemplateDeep('standard-report') as ReportDocument;

if (report1) {
  report1.header.title = 'Q4 2024 Financial Report';
  report1.header.preparedBy = 'Finance Team';
  report1.header.department = 'Finance';
  report1.reportType = ReportType.Financial;
  report1.sections.push({ sectionTitle: 'Revenue Analysis', content: 'Detailed revenue analysis for Q4 2024', keyPoints: [], order: 2 });
  report1.summary.executiveSummary = 'Strong performance in Q4 2024';
  report1.summary.recommendations.push('Continue current strategy', 'Invest in new markets');

  console.log(`Report1: ${report1.getDocumentInfo()} | Valid: ${report1.validateDocument()}`);
}

// --- Shallow vs Deep Clone ---
console.log('\n--- Shallow vs Deep Clone ---');
const original = templateManager.createDocumentFromTemplate('standard-proposal') as ProposalDocument;
const shallow = original?.clone() as ProposalDocument;
const deep = original?.deepClone() as ProposalDocument;

if (original && shallow && deep) {
  original.clientInfo.companyName = 'Modified Company';
  console.log(`Original:      ${original.clientInfo.companyName}`);
  console.log(`Shallow Clone: ${shallow.clientInfo.companyName}`);  // shares reference -> same value
  console.log(`Deep Clone:    ${deep.clientInfo.companyName}`);     // independent copy -> original value
}

// --- Performance: 1000 Clones ---
console.log('\n--- Performance: 1000 Clones ---');
let start = Date.now();
for (let i = 0; i < 1000; i++) templateManager.createDocumentFromTemplate('standard-cv');
console.log(`Shallow Clone (1000x): ${Date.now() - start}ms`);

start = Date.now();
for (let i = 0; i < 1000; i++) templateManager.createDocumentFromTemplateDeep('standard-cv');
console.log(`Deep Clone    (1000x): ${Date.now() - start}ms`);
