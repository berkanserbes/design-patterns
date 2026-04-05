import { ICommand } from "./ICommand";
import { Light } from "./Light";

/** Null Object — does nothing (used for unassigned buttons) */
export class NoCommand implements ICommand {
  execute(): void {}
  undo(): void {}
}

export class LightOnCommand implements ICommand {
  constructor(private readonly _light: Light) {}
  execute(): void { this._light.turnOn(); }
  undo(): void    { this._light.turnOff(); }
}

export class LightOffCommand implements ICommand {
  constructor(private readonly _light: Light) {}
  execute(): void { this._light.turnOff(); }
  undo(): void    { this._light.turnOn(); }
}

export class IncreaseBrightnessCommand implements ICommand {
  constructor(private readonly _light: Light) {}
  execute(): void { this._light.increaseBrightness(); }
  undo(): void    { this._light.decreaseBrightness(); }
}
