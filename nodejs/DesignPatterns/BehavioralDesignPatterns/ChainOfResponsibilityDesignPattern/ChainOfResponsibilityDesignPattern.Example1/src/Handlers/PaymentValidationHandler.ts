import { BaseOrderHandler } from "../BaseOrderHandler";
import { OrderRequest } from "../OrderRequest";

export class PaymentValidationHandler extends BaseOrderHandler {
	private readonly _balances: Map<string, number> = new Map([
		["John Doe",       5000],
		["Jane Smith",     1500],
		["Bob Johnson",     500],
		["Alice Williams", 10000],
	]);

	handle(request: OrderRequest): void {
		const balance = this._balances.get(request.customerName);
		if (balance === undefined) {
			request.addMessage(`Payment failed: Customer '${request.customerName}' not found`);
			request.isApproved = false;
			return;
		}
		if (balance >= request.totalAmount) {
			this._balances.set(request.customerName, balance - request.totalAmount);
			request.addMessage(`Payment validated: $${request.totalAmount.toFixed(2)} charged`);
			super.handle(request);
		} else {
			request.addMessage(`Insufficient balance: Need $${request.totalAmount.toFixed(2)}, available $${balance.toFixed(2)}`);
			request.isApproved = false;
		}
	}
}
