package creational.builder.example2;

public class Main {
    public static void main(String[] args) {
        Pizza pizza = new Pizza.PizzaBuilder()
                .setSize("Large")
                .setDough("Thin Crust")
                .setSauce("Tomato")
                .addCheese()
                .addPepperoni()
                .build();

        System.out.println(pizza);
    }
}
