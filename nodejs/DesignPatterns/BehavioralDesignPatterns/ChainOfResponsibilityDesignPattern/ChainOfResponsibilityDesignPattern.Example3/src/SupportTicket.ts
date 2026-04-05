export enum TicketPriority {
  Low      = 0,
  Medium   = 1,
  High     = 2,
  Critical = 3,
}

export enum TicketCategory {
  Technical = "Technical",
  Billing   = "Billing",
  Account   = "Account",
  General   = "General",
}

export class SupportTicket {
  isResolved  = false;
  resolvedBy?: string;
  resolution?: string;

  constructor(
    public readonly ticketId: number,
    public readonly customerName: string,
    public readonly issue: string,
    public readonly priority: TicketPriority,
    public readonly category: TicketCategory
  ) {}

  resolve(handler: string, resolution: string): void {
    this.isResolved = true;
    this.resolvedBy = handler;
    this.resolution = resolution;
  }
}

export interface ISupportHandler {
  setNext(handler: ISupportHandler): ISupportHandler;
  handleTicket(ticket: SupportTicket): void;
}
