import { SupportTicket, TicketCategory, TicketPriority } from "../SupportTicket";
import { BaseSupportHandler } from "../BaseSupportHandler";

export class Level2SupportHandler extends BaseSupportHandler {
  constructor() { super("Level 2 Support"); }

  handleTicket(ticket: SupportTicket): void {
    if (
      this.canHandle(ticket, TicketPriority.Medium, [
        TicketCategory.Technical,
        TicketCategory.Account,
        TicketCategory.General,
      ])
    ) {
      ticket.resolve(this.handlerName, "Performed advanced diagnostics and applied technical solution.");
    } else {
      super.handleTicket(ticket);
    }
  }
}
