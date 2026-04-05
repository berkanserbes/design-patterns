import { AirTrafficControlTower } from './AirTrafficControlTower';
import { CommercialAircraft } from './CommercialAircraft';
import { CargoAircraft } from './CargoAircraft';

const sleep = (ms: number) => new Promise<void>(resolve => setTimeout(resolve, ms));

async function main() {
  const tower = new AirTrafficControlTower();

  console.log('=== AIRCRAFT REGISTRATION ===\n');

  const turkishAirlines = new CommercialAircraft(tower, 'THY-101');
  tower.registerAircraft(turkishAirlines);

  const pegasus = new CommercialAircraft(tower, 'PGS-202');
  tower.registerAircraft(pegasus);

  const cargoPlane = new CargoAircraft(tower, 'CARGO-303');
  tower.registerAircraft(cargoPlane);

  const emirates = new CommercialAircraft(tower, 'EK-404');
  tower.registerAircraft(emirates);

  console.log('\n=== INTER-AIRCRAFT COMMUNICATION ===\n');

  turkishAirlines.send('Hello, approaching the airport.');
  await sleep(500);

  pegasus.send('We are also approaching, fuel status is critical.');
  await sleep(500);

  console.log('\n=== LANDING AND TAKEOFF REQUESTS ===\n');

  turkishAirlines.requestLanding();
  await sleep(500);

  pegasus.requestLanding();
  await sleep(500);

  emirates.requestLanding();
  await sleep(500);

  cargoPlane.requestTakeoff();
  await sleep(500);

  console.log('\n=== RUNWAY OPERATIONS IN PROGRESS ===');
  console.log('(Please wait, operations will proceed automatically in sequence...)\n');

  await sleep(15000);
}

main();
