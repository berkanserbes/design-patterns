using CommandDesignPattern.Example2;

Console.WriteLine("=== Akıllı Ev Kontrol Sistemi ===\n");

// Receivers (Cihazlar)
Light livingRoomLight = new Light("Oturma Odası");
Light kitchenLight = new Light("Mutfak");
Light bedroomLight = new Light("Yatak Odası");

// Commands
LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

IncreaseBrightnessCommand bedroomBrightnessUp = new IncreaseBrightnessCommand(bedroomLight);
LightOffCommand bedroomLightOff = new LightOffCommand(bedroomLight);

// Invoker
RemoteControl remote = new RemoteControl();

// Komutları butonlara atama
remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
remote.SetCommand(2, bedroomBrightnessUp, bedroomLightOff);

// Uzaktan kumanda durumunu göster
remote.PrintCommands();

// Kullanım Senaryosu
Console.WriteLine("\n--- Test Senaryosu ---");

Console.WriteLine("\n1. Oturma odası ışığını aç:");
remote.OnButtonPressed(0);

Console.WriteLine("\n2. Mutfak ışığını aç:");
remote.OnButtonPressed(1);

Console.WriteLine("\n3. Yatak odası parlaklığını artır:");
remote.OnButtonPressed(2);

Console.WriteLine("\n4. Son işlemi geri al (Undo):");
remote.UndoButtonPressed();

Console.WriteLine("\n5. Oturma odası ışığını kapat:");
remote.OffButtonPressed(0);

Console.WriteLine("\n6. Son işlemi geri al (Undo):");
remote.UndoButtonPressed();

Console.ReadLine();