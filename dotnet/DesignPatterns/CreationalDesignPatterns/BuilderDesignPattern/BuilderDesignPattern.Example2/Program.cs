using BuilderDesignPattern.Example2;

var pizza = new Pizza.PizzaBuilder()
			.SetSize("Large")
			.SetDough("Thin Crust")
			.SetSauce("Tomato")
			.AddCheese()
			.AddPepperoni()
			.Build();

Console.WriteLine(pizza);