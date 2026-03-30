package creational.builder.example2;

public class Pizza {
    private String size;
    private String dough;
    private String sauce;
    private boolean hasCheese;
    private boolean hasPepperoni;
    private boolean hasMushrooms;
    private boolean hasOlives;

    private Pizza() { }

    @Override
    public String toString() {
        return "Pizza: Size=" + size + ", Dough=" + dough + ", Sauce=" + sauce +
               ", Cheese=" + hasCheese + ", Pepperoni=" + hasPepperoni +
               ", Mushrooms=" + hasMushrooms + ", Olives=" + hasOlives;
    }

    public static class PizzaBuilder {
        private final Pizza pizza = new Pizza();

        public PizzaBuilder setSize(String size)     { pizza.size   = size;   return this; }
        public PizzaBuilder setDough(String dough)   { pizza.dough  = dough;  return this; }
        public PizzaBuilder setSauce(String sauce)   { pizza.sauce  = sauce;  return this; }
        public PizzaBuilder addCheese()              { pizza.hasCheese    = true; return this; }
        public PizzaBuilder addPepperoni()           { pizza.hasPepperoni = true; return this; }
        public PizzaBuilder addMushrooms()           { pizza.hasMushrooms = true; return this; }
        public PizzaBuilder addOlives()              { pizza.hasOlives    = true; return this; }

        public Pizza build() {
            if (pizza.size == null || pizza.size.isBlank() ||
                pizza.dough == null || pizza.dough.isBlank()) {
                throw new IllegalStateException("Pizza must have both Size and Dough set.");
            }
            return pizza;
        }
    }
}
