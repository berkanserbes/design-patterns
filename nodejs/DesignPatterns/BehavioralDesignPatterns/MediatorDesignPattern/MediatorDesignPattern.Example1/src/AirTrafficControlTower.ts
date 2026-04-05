import { IMediator } from './IMediator';
import { Aircraft } from './Aircraft';

const sleep = (ms: number) => new Promise<void>(resolve => setTimeout(resolve, ms));

export class AirTrafficControlTower implements IMediator {
  private readonly _aircrafts: Aircraft[] = [];
  private readonly _landingQueue: Aircraft[] = [];
  private readonly _takeoffQueue: Aircraft[] = [];
  private _runwayAvailable: boolean = true;

  registerAircraft(aircraft: Aircraft): void {
    this._aircrafts.push(aircraft);
    console.log(`[TOWER] ${aircraft.callSign} (${aircraft.aircraftType}) registered to the system.`);
  }

  sendMessage(message: string, sender: Aircraft): void {
    for (const aircraft of this._aircrafts.filter(a => a !== sender)) {
      aircraft.receive(`${sender.callSign}: ${message}`);
    }
  }

  requestLanding(aircraft: Aircraft): void {
    if (this._runwayAvailable && this._landingQueue.length === 0) {
      this._clearForLanding(aircraft);
    } else {
      this._landingQueue.push(aircraft);
      console.log(`[TOWER] ${aircraft.callSign}, runway is busy. You are #${this._landingQueue.length} in queue.`);
      aircraft.receive(`[TOWER] Please hold, you will be notified when it's your turn.`);
    }
  }

  requestTakeoff(aircraft: Aircraft): void {
    if (this._runwayAvailable && this._takeoffQueue.length === 0 && this._landingQueue.length === 0) {
      this._clearForTakeoff(aircraft);
    } else {
      this._takeoffQueue.push(aircraft);
      console.log(`[TOWER] ${aircraft.callSign}, runway is busy or landing has priority. You are #${this._takeoffQueue.length} in queue.`);
      aircraft.receive(`[TOWER] Please hold, you will be notified when it's your turn.`);
    }
  }

  private _clearForLanding(aircraft: Aircraft): void {
    this._runwayAvailable = false;
    console.log(`[TOWER] ${aircraft.callSign}, cleared for landing. Runway is clear.`);
    for (const other of this._aircrafts.filter(a => a !== aircraft)) {
      other.receive(`[TOWER] ${aircraft.callSign} is landing, please hold.`);
    }
    setTimeout(() => {
      this._runwayAvailable = true;
      console.log(`[TOWER] ${aircraft.callSign} landing completed. Runway is clear.`);
      this._processNextInQueue();
    }, 3000);
  }

  private _clearForTakeoff(aircraft: Aircraft): void {
    this._runwayAvailable = false;
    console.log(`[TOWER] ${aircraft.callSign}, cleared for takeoff. Have a safe flight!`);
    for (const other of this._aircrafts.filter(a => a !== aircraft)) {
      other.receive(`[TOWER] ${aircraft.callSign} is taking off.`);
    }
    setTimeout(() => {
      this._runwayAvailable = true;
      console.log(`[TOWER] ${aircraft.callSign} takeoff completed. Runway is clear.`);
      this._processNextInQueue();
    }, 2000);
  }

  private _processNextInQueue(): void {
    if (this._landingQueue.length > 0) {
      const next = this._landingQueue.shift()!;
      console.log(`[TOWER] Calling next aircraft: ${next.callSign}`);
      this._clearForLanding(next);
    } else if (this._takeoffQueue.length > 0) {
      const next = this._takeoffQueue.shift()!;
      console.log(`[TOWER] Calling next aircraft: ${next.callSign}`);
      this._clearForTakeoff(next);
    }
  }
}
