import { SupportTicket, TicketCategory, TicketPriority } from "../SupportTicket";
import { BaseSupportHandler } from "../BaseSupportHandler";

export class Level1SupportHandler extends BaseSupportHandler {
  constructor() { super("Level 1 Support"); }

  handleTicket(ticket: SupportTicket): void {
    if (this.canHandle(ticket, TicketPriority.Low, [TicketCategory.General])) {
      ticket.resolve(this.handlerName, "Provided basic troubleshooting steps and FAQ links.");
    } else {
      super.handleTicket(ticket);
    }
  }
}
