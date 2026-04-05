import { BaseOrderHandler } from "../BaseOrderHandler";
import { OrderRequest } from "../OrderRequest";

export class DiscountHandler extends BaseOrderHandler {
	private readonly _discountCodes: Map<string, number> = new Map([
		["SUMMER20",   0.20],
		["WELCOME10",  0.10],
		["VIP30",      0.30],
		["NEWYEAR15",  0.15],
	]);

	handle(request: OrderRequest): void {
		if (!request.discountCode) {
			request.addMessage("No discount code applied");
			super.handle(request);
			return;
		}
		const rate = this._discountCodes.get(request.discountCode);
		if (rate !== undefined) {
			const discountAmount = request.totalAmount * rate;
			request.totalAmount -= discountAmount;
			request.addMessage(`Discount applied: ${rate * 100}% off, saved $${discountAmount.toFixed(2)}`);
		} else {
			request.addMessage(`Invalid discount code: '${request.discountCode}'`);
		}
		super.handle(request);
	}
}
