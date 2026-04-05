import { ISupportHandler, SupportTicket, TicketCategory, TicketPriority } from "./SupportTicket";

export abstract class BaseSupportHandler implements ISupportHandler {
  private _nextHandler: ISupportHandler | null = null;

  constructor(protected readonly handlerName: string) {}

  setNext(handler: ISupportHandler): ISupportHandler {
    this._nextHandler = handler;
    return handler;
  }

  handleTicket(ticket: SupportTicket): void {
    if (this._nextHandler) {
      this._nextHandler.handleTicket(ticket);
    }
  }

  protected canHandle(
    ticket: SupportTicket,
    maxPriority: TicketPriority,
    categories?: TicketCategory[]
  ): boolean {
    const priorityMatch = ticket.priority <= maxPriority;
    const categoryMatch = !categories || categories.includes(ticket.category);
    return priorityMatch && categoryMatch;
  }
}
