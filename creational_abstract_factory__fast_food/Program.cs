// Interface cho Abstract Factory
interface IRestaurantFactory
{
    IFood CreateFood();
    ITopping CreateTopping();
}

// Interface for some food
interface IFood
{
    string GetName();
}

// Interface for some topping
interface ITopping
{
    string GetName();
}

// Concrete Factory cho pizza
class PizzaFactory : IRestaurantFactory
{
    public IFood CreateFood()
    {
        return new Pizza();
    }

    public ITopping CreateTopping()
    {
        return new TomatoTopping();
    }
}

// Concrete Factory cho burger
class BurgerFactory : IRestaurantFactory
{
    public IFood CreateFood()
    {
        return new Burger();
    }

    public ITopping CreateTopping()
    {
        return new LettuceTopping();
    }
}

// Concrete Product: Pizza
class Pizza : IFood
{
    public string GetName()
    {
        return "Pizza";
    }
}

// Concrete Product: Burger
class Burger : IFood
{
    public string GetName()
    {
        return "Burger";
    }
}

// Concrete Product: Tomato Topping
class TomatoTopping : ITopping
{
    public string GetName()
    {
        return "Tomato";
    }
}

// Concrete Product: Lettuce Topping
class LettuceTopping : ITopping
{
    public string GetName()
    {
        return "Lettuce";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create factory for Pizza
        IRestaurantFactory pizzaFactory = new PizzaFactory();
        IFood pizza = pizzaFactory.CreateFood();
        ITopping pizzaTopping = pizzaFactory.CreateTopping();
        Console.WriteLine($"Ordered {pizza.GetName()} with {pizzaTopping.GetName()}");

        // Create factory for Burger
        IRestaurantFactory burgerFactory = new BurgerFactory();
        IFood burger = burgerFactory.CreateFood();
        ITopping burgerTopping = burgerFactory.CreateTopping();
        Console.WriteLine($"Ordered {burger.GetName()} with {burgerTopping.GetName()}");
    }
}
