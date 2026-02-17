namespace ConsoleApp13;

public class PizzaService : IPizzaService
{
    public Pizza GetBiggestRadiusPizza(Pizza[] pizzas)
    {
        Pizza biggest = pizzas[0];
        foreach (var p in pizzas)
        {
            if (p.Radius > biggest.Radius) biggest = p;
        }
        return biggest;
    }

    public Pizza CreatePizza(int id, string name, DateTime releaseDate, TimeSpan preparationTime, double calories,
        double radius, bool isSpicy)
    {
        Pizza newPizza = new Pizza(id, name, releaseDate, preparationTime, calories, radius, isSpicy);
        return newPizza;
    }
}