using ObserverDesignPattern.Example2;

Console.WriteLine("=== Weather Condition Tracking System ===\n");

// Subject'i oluştur
WeatherStation weatherStation = new WeatherStation();

// Observer'ları oluştur ve kaydet
CurrentConditionsDisplay currentDisplay =
    new CurrentConditionsDisplay(weatherStation);

StatisticsDisplay statisticsDisplay =
    new StatisticsDisplay(weatherStation);

ForecastDisplay forecastDisplay =
    new ForecastDisplay(weatherStation);

Console.WriteLine("\n--- First Measurement ---");
weatherStation.SetMeasurements(25.0f, 65.0f, 1013.0f);

Console.WriteLine("\n--- Second Measurement ---");
weatherStation.SetMeasurements(28.0f, 70.0f, 1012.0f);

Console.WriteLine("\n--- Third Measurement ---");
weatherStation.SetMeasurements(22.0f, 90.0f, 1010.0f);

// Dinamik olarak bir observer'ı çıkaralım
Console.WriteLine("\n--- Current Conditions Display Unregistered ---");
weatherStation.RemoveObserver(currentDisplay);

Console.WriteLine("\n--- Forth Measurement ---");
weatherStation.SetMeasurements(20.0f, 85.0f, 1008.0f);