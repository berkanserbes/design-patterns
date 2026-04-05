import { IWorkshop } from './IWorkshop';

export abstract class Vehicle {
  constructor(
    protected readonly workshop1: IWorkshop,
    protected readonly workshop2: IWorkshop,
  ) {}
  abstract manufacture(): void;
}
