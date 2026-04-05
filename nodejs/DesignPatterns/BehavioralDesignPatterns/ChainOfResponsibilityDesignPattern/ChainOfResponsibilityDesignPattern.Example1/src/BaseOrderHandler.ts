import { IOrderHandler, OrderRequest } from "./OrderRequest";

export abstract class BaseOrderHandler implements IOrderHandler {
  private _nextHandler: IOrderHandler | null = null;

  setNext(handler: IOrderHandler): IOrderHandler {
    this._nextHandler = handler;
    return handler;
  }

  handle(request: OrderRequest): void {
    if (this._nextHandler) {
      this._nextHandler.handle(request);
    }
  }
}
