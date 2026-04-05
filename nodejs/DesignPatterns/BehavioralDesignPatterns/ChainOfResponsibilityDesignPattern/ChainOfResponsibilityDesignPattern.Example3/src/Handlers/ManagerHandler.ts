import { SupportTicket, TicketPriority } from "../SupportTicket";
import { BaseSupportHandler } from "../BaseSupportHandler";

export class ManagerHandler extends BaseSupportHandler {
  constructor() { super("Support Manager"); }

  handleTicket(ticket: SupportTicket): void {
    if (ticket.priority === TicketPriority.Critical) {
      ticket.resolve(
        this.handlerName,
        "Escalated to engineering team, provided temporary workaround, and scheduled priority fix."
      );
    } else {
      super.handleTicket(ticket);
    }
  }
}
