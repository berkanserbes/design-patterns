import { Tv } from './Tv';
import { Radio } from './Radio';
import { Remote } from './Remote';
import { AdvancedRemote } from './AdvancedRemote';

const tv = new Tv();
const remote = new Remote(tv);

remote.togglePower();
remote.volumeUp();
console.log(`TV Volume: ${tv.volume}`);

const radio = new Radio();
const advRemote = new AdvancedRemote(radio);

advRemote.togglePower();
advRemote.mute();
console.log(`Radio Volume: ${radio.volume}`);
