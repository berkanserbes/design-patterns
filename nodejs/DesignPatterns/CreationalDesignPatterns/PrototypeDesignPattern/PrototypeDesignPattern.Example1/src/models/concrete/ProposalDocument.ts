import { DocumentBase } from '../abstract/DocumentBase';

export class ClientInfo {
  companyName: string = '';
  contactPerson: string = '';
  email: string = '';
  address: string = '';
}

export class ProposalItem {
  description: string = '';
  quantity: number = 0;
  unitPrice: number = 0;
  notes: string = '';
}

export class ProposalDocument extends DocumentBase {
  clientInfo: ClientInfo = new ClientInfo();
  proposalItems: ProposalItem[] = [];
  totalAmount: number = 0;
  validityDays: number = 30;
  terms: string = '';

  constructor() {
    super();
    this.title = 'Business Proposal Template';
    this.content = 'Professional Business Proposal';
    this.metadata.tags.push('Proposal', 'Business', 'Sales');
  }

  validateDocument(): boolean {
    return !!this.clientInfo.companyName && this.proposalItems.length > 0 && this.totalAmount > 0;
  }

  calculateTotal(): void {
    this.totalAmount = this.proposalItems.reduce((sum, item) => sum + item.quantity * item.unitPrice, 0);
  }

  override getDocumentInfo(): string {
    return `${super.getDocumentInfo()}, Client: ${this.clientInfo.companyName}, Total: $${this.totalAmount.toFixed(2)}, Items: ${this.proposalItems.length}`;
  }
}
