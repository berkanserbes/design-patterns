// ============================================================================
// COMMAND DESIGN PATTERN - Example 2: Smart Home Remote Control
// ============================================================================
// Demonstrates Command pattern with a 7-slot remote control (Invoker),
// Light devices (Receivers), and a single-level undo.
// Uses the Null Object Pattern for unassigned slots (NoCommand).
//
// Pattern Structure:
//   - ICommand: Command interface (execute, undo)
//   - LightOnCommand / LightOffCommand / IncreaseBrightnessCommand: Concrete Commands
//   - NoCommand: Null Object for empty slots
//   - Light: Receiver
//   - RemoteControl: Invoker
// ============================================================================

import {
  IncreaseBrightnessCommand,
  LightOffCommand,
  LightOnCommand,
} from "./Commands";
import { Light } from "./Light";
import { RemoteControl } from "./RemoteControl";

console.log("=== Smart Home Control System ===\n");

// Receivers
const livingRoomLight = new Light("Living Room");
const kitchenLight    = new Light("Kitchen");
const bedroomLight    = new Light("Bedroom");

// Commands
const livingRoomOn    = new LightOnCommand(livingRoomLight);
const livingRoomOff   = new LightOffCommand(livingRoomLight);
const kitchenOn       = new LightOnCommand(kitchenLight);
const kitchenOff      = new LightOffCommand(kitchenLight);
const bedroomBrightUp = new IncreaseBrightnessCommand(bedroomLight);
const bedroomOff      = new LightOffCommand(bedroomLight);

// Invoker
const remote = new RemoteControl();
remote.setCommand(0, livingRoomOn,  livingRoomOff);
remote.setCommand(1, kitchenOn,     kitchenOff);
remote.setCommand(2, bedroomBrightUp, bedroomOff);

remote.printCommands();

console.log("\n--- Test Scenario ---");

console.log("\n1. Turn on living room light:");
remote.onButtonPressed(0);

console.log("\n2. Turn on kitchen light:");
remote.onButtonPressed(1);

console.log("\n3. Increase bedroom brightness:");
remote.onButtonPressed(2);

console.log("\n4. Undo last action:");
remote.undoButtonPressed();

console.log("\n5. Turn off living room light:");
remote.offButtonPressed(0);

console.log("\n6. Undo last action:");
remote.undoButtonPressed();
