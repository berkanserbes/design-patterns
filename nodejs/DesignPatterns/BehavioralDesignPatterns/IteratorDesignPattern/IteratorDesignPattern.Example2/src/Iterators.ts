import { IIterator } from "./Interfaces";
import { Order, OrderStatus } from "./Order";
import { OrderCollection } from "./OrderCollection";

export class OrderIterator implements IIterator<Order> {
  private _currentIndex = 0;
  constructor(private readonly _collection: OrderCollection) {}
  hasNext(): boolean { return this._currentIndex < this._collection.count; }
  next(): Order {
    if (!this.hasNext()) throw new Error("No more orders.");
    return this._collection.getAt(this._currentIndex++);
  }
  reset(): void { this._currentIndex = 0; }
}

export class StatusFilterIterator implements IIterator<Order> {
  private _currentIndex = 0;
  constructor(
    private readonly _collection: OrderCollection,
    private readonly _filterStatus: OrderStatus
  ) {}
  hasNext(): boolean {
    while (this._currentIndex < this._collection.count) {
      if (this._collection.getAt(this._currentIndex).status === this._filterStatus) return true;
      this._currentIndex++;
    }
    return false;
  }
  next(): Order {
    if (!this.hasNext()) throw new Error("No more orders matching the status filter.");
    return this._collection.getAt(this._currentIndex++);
  }
  reset(): void { this._currentIndex = 0; }
}

export class DateRangeIterator implements IIterator<Order> {
  private _currentIndex = 0;
  constructor(
    private readonly _collection: OrderCollection,
    private readonly _startDate: Date,
    private readonly _endDate: Date
  ) {}
  hasNext(): boolean {
    while (this._currentIndex < this._collection.count) {
      const orderDate = this._collection.getAt(this._currentIndex).orderDate;
      if (orderDate >= this._startDate && orderDate <= this._endDate) return true;
      this._currentIndex++;
    }
    return false;
  }
  next(): Order {
    if (!this.hasNext()) throw new Error("No more orders in the date range.");
    return this._collection.getAt(this._currentIndex++);
  }
  reset(): void { this._currentIndex = 0; }
}

export class HighValueOrderIterator implements IIterator<Order> {
  private _currentIndex = 0;
  constructor(
    private readonly _collection: OrderCollection,
    private readonly _minAmount: number
  ) {}
  hasNext(): boolean {
    while (this._currentIndex < this._collection.count) {
      if (this._collection.getAt(this._currentIndex).totalAmount >= this._minAmount) return true;
      this._currentIndex++;
    }
    return false;
  }
  next(): Order {
    if (!this.hasNext()) throw new Error("No more high value orders.");
    return this._collection.getAt(this._currentIndex++);
  }
  reset(): void { this._currentIndex = 0; }
}
