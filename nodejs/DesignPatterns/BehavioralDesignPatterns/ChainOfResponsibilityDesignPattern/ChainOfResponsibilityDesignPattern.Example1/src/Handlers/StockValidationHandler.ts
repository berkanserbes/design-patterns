import { BaseOrderHandler } from "../BaseOrderHandler";
import { OrderRequest } from "../OrderRequest";

export class StockValidationHandler extends BaseOrderHandler {
	private readonly _stock: Map<string, number> = new Map([
		["Laptop",     10],
		["Mouse",      50],
		["Keyboard",   30],
		["Monitor",     5],
		["Headphones",  0],
	]);

	handle(request: OrderRequest): void {
		const available = this._stock.get(request.productName);
		if (available === undefined) {
			request.addMessage(`Stock validation failed: Product '${request.productName}' not found`);
			request.isApproved = false;
			return;
		}
		if (available >= request.quantity) {
			this._stock.set(request.productName, available - request.quantity);
			request.addMessage(`Stock validated: ${request.quantity} units available`);
			super.handle(request);
		} else {
			request.addMessage(`Insufficient stock: Need ${request.quantity}, available ${available}`);
			request.isApproved = false;
		}
	}
}
