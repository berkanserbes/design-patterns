namespace BuilderDesignPattern.Example2;

public class Pizza
{
	public string Size { get; private set; }
	public string Dough { get; private set; }
	public string Sauce { get; private set; }
	public bool HasCheese { get; private set; }
	public bool HasPepperoni { get; private set; }
	public bool HasMushrooms { get; private set; }
	public bool HasOlives { get; private set; }

	private Pizza() { }

	public override string ToString()
	{
		return $"Pizza: Size={Size}, Dough={Dough}, Sauce={Sauce}, Cheese={HasCheese}, " +
			   $"Pepperoni={HasPepperoni}, Mushrooms={HasMushrooms}, Olives={HasOlives}";
	}

	public class PizzaBuilder
	{
		private readonly Pizza _pizza;

		public PizzaBuilder()
		{
			_pizza = new Pizza();
		}

		public PizzaBuilder SetSize(string size)
		{
			_pizza.Size = size;
			return this;
		}

		public PizzaBuilder SetDough(string dough)
		{
			_pizza.Dough = dough;
			return this;
		}

		public PizzaBuilder SetSauce(string sauce)
		{
			_pizza.Sauce = sauce;
			return this;
		}

		public PizzaBuilder AddCheese()
		{
			_pizza.HasCheese = true;
			return this;
		}

		public PizzaBuilder AddPepperoni()
		{
			_pizza.HasPepperoni = true;
			return this;
		}

		public PizzaBuilder AddMushrooms()
		{
			_pizza.HasMushrooms = true;
			return this;
		}

		public PizzaBuilder AddOlives()
		{
			_pizza.HasOlives = true;
			return this;
		}

		public Pizza Build()
		{
			if (string.IsNullOrWhiteSpace(_pizza.Size) || string.IsNullOrWhiteSpace(_pizza.Dough))
			{
				throw new InvalidOperationException("Pizza must have both Size and Dough set.");
			}

			return _pizza;
		}
	}
}
