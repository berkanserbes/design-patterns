export interface ITreeType {
  readonly name: string;
  readonly color: string;
  readonly texture: string;
  draw(x: number, y: number): void;
}
