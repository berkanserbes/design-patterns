import { Projector } from './models/Projector';
import { Amplifier } from './models/Amplifier';
import { DvdPlayer } from './models/DvdPlayer';
import { Lights } from './models/Lights';
import { HomeTheaterFacade } from './HomeTheaterFacade';

const projector = new Projector();
const amplifier = new Amplifier();
const dvdPlayer = new DvdPlayer();
const lights = new Lights();

const homeTheater = new HomeTheaterFacade(projector, amplifier, dvdPlayer, lights);

homeTheater.watchMovie('Inception');
console.log('\nAfter a while...');
homeTheater.endMovie();
