export class Pizza {
  size: string = '';
  dough: string = '';
  sauce: string = '';
  hasCheese: boolean = false;
  hasPepperoni: boolean = false;
  hasMushrooms: boolean = false;
  hasOlives: boolean = false;

  private constructor() {}

  toString(): string {
    return (
      `Pizza: Size=${this.size}, Dough=${this.dough}, Sauce=${this.sauce}, ` +
      `Cheese=${this.hasCheese}, Pepperoni=${this.hasPepperoni}, ` +
      `Mushrooms=${this.hasMushrooms}, Olives=${this.hasOlives}`
    );
  }

  static Builder = class PizzaBuilder {
    private readonly _pizza: Pizza = new Pizza();

    setSize(size: string): this {
      this._pizza.size = size;
      return this;
    }

    setDough(dough: string): this {
      this._pizza.dough = dough;
      return this;
    }

    setSauce(sauce: string): this {
      this._pizza.sauce = sauce;
      return this;
    }

    addCheese(): this {
      this._pizza.hasCheese = true;
      return this;
    }

    addPepperoni(): this {
      this._pizza.hasPepperoni = true;
      return this;
    }

    addMushrooms(): this {
      this._pizza.hasMushrooms = true;
      return this;
    }

    addOlives(): this {
      this._pizza.hasOlives = true;
      return this;
    }

    build(): Pizza {
      if (!this._pizza.size || !this._pizza.dough) {
        throw new Error('Pizza must have both Size and Dough set.');
      }
      return this._pizza;
    }
  };
}
