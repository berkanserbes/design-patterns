export abstract class Menu {
  abstract render(): void;
  abstract addItem(item: string): void;
}
