import { SupportTicket, TicketPriority } from "../SupportTicket";
import { BaseSupportHandler } from "../BaseSupportHandler";

export class TeamLeadHandler extends BaseSupportHandler {
  constructor() { super("Team Lead"); }

  handleTicket(ticket: SupportTicket): void {
    if (this.canHandle(ticket, TicketPriority.High)) {
      ticket.resolve(this.handlerName, "Coordinated with technical team and implemented custom solution.");
    } else {
      super.handleTicket(ticket);
    }
  }
}
