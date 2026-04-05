import { BaseOrderHandler } from "../BaseOrderHandler";
import { OrderRequest } from "../OrderRequest";

export class ShippingHandler extends BaseOrderHandler {
	handle(request: OrderRequest): void {
		const method = request.totalAmount > 1000 ? "Express" : "Standard";
		const tracking = `TRK${Math.floor(Math.random() * 900000) + 100000}`;
		request.addMessage(`Shipping arranged: ${method} (${tracking})`);
		request.isApproved = true;
		super.handle(request);
	}
}
