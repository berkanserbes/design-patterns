import { IColor } from './IColor';

export class Red implements IColor 
{ 
    fill(): void { console.log('Filling with Red color'); } 
}
