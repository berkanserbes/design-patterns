import { WeatherStation } from './WeatherStation';
import { CurrentConditionsDisplay } from './CurrentConditionsDisplay';
import { StatisticsDisplay } from './StatisticsDisplay';
import { ForecastDisplay } from './ForecastDisplay';

console.log('=== Weather Condition Tracking System ===\n');

const weatherStation = new WeatherStation();

const currentDisplay = new CurrentConditionsDisplay(weatherStation);
const statisticsDisplay = new StatisticsDisplay(weatherStation);
const forecastDisplay = new ForecastDisplay(weatherStation);

console.log('\n--- First Measurement ---');
weatherStation.setMeasurements(25.0, 65.0, 1013.0);

console.log('\n--- Second Measurement ---');
weatherStation.setMeasurements(28.0, 70.0, 1012.0);

console.log('\n--- Third Measurement ---');
weatherStation.setMeasurements(22.0, 90.0, 1010.0);

console.log('\n--- Current Conditions Display Unregistered ---');
weatherStation.removeObserver(currentDisplay);

console.log('\n--- Fourth Measurement ---');
weatherStation.setMeasurements(20.0, 85.0, 1008.0);
