import { IColor } from './IColor';

export class Green implements IColor 
{ 
    fill(): void { console.log('Filling with Green color'); } 
}
