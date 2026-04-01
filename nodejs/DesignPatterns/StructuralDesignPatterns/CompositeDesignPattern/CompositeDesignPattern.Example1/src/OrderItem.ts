export abstract class OrderItem {
  constructor(public readonly name: string) {}
  abstract getWeight(): number;
}
